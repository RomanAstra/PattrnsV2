using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVM.ViewManager
{
    internal sealed class ViewManager
    {
        private readonly Dictionary<Type, List<IView>> _views = new (16);
        private readonly Stack<IView> _viewsStack = new ();
        private readonly List<IView> _outOfStackWindows = new ();
        private readonly Queue<Action> _modalWindowsCallsQueue = new ();
        private IView _modalWindow;
        
        public void Register<T>(IView<T> view) where T : class, IViewModel
        {
            if (view == null)
            {
                throw new ArgumentNullException();
            }

            var type = typeof(T);
            if (!_views.ContainsKey(type))
            {
                _views.Add(type, new List<IView>(2));
            }

            _views[type].Add(view);
        }

        public IView<T> ShowWindow<T>(T viewModel) where T : class, IViewModel
        {
            var view = GetView(viewModel);

            TryCloseViewIfItAlreadyShown(view);

            viewModel.Closed += Close;
            view.Initialize(viewModel);

            if (_viewsStack.Count > 0)
            {
                _viewsStack.Peek().Unfocus();
            }

            view.Show();
            view.Focus();

            _viewsStack.Push(view);
            return view;
        }

        public IView<T> ShowWindowOutOfStack<T>(T viewModel) where T : class, IViewModel
        {
            var view = GetView(viewModel);

            TryCloseViewIfItAlreadyShown(view);

            viewModel.Closed += Close;
            view.Initialize(viewModel);

            view.Show();
            view.Focus();

            _outOfStackWindows.Add(view);
            return view;
        }

        public void ShowModalWindow<T>(T viewModel) where T : class, IViewModel
        {
            if (_modalWindow != null)
            {
                _modalWindowsCallsQueue.Enqueue(() => ShowModalWindow(viewModel));
                return;
            }

            _modalWindow = ShowWindow(viewModel);
        }

        private IView<T> GetView<T>(T viewModel) where T : class, IViewModel
        {
            var type = typeof(T);
            if (_views.ContainsKey(type))
            {
                var view = (IView<T>) _views[type];
                return view;
            }
            else
            {
                var view = (IView<T>) _views.First(a => a.Key.IsAssignableFrom(type)).Value;
                return view;
            }
        }

        private void Close(IViewModel viewModel)
        {
            viewModel.Closed -= Close;
            if (_viewsStack.Count == 0)
            {
                throw new InvalidOperationException("Try to close not opened view model");
            }

            IView currentView;
            var outOfStack = _outOfStackWindows.FirstOrDefault(a => a.ViewModel == viewModel);
            if (outOfStack != null)
            {
                currentView = outOfStack;
                _outOfStackWindows.Remove(outOfStack);
            }
            else
            {
                while (_viewsStack.Peek().ViewModel != viewModel)
                {
                    var view = _viewsStack.Peek();
                    view.ViewModel.Close();
                }

                currentView = _viewsStack.Pop();
            }

            currentView.Unfocus();
            currentView.Hide();

            if (_viewsStack.Count > 0)
            {
                var view = _viewsStack.Peek();
                view.Focus();
            }

            if (_modalWindow != null && _modalWindow.ViewModel == viewModel)
            {
                _modalWindow = null;
                if (_modalWindowsCallsQueue.Count > 0)
                {
                    _modalWindowsCallsQueue.Dequeue().Invoke();
                }
            }
        }

        private void TryCloseViewIfItAlreadyShown<T>(IView<T> view) where T : class, IViewModel
        {
            if (_viewsStack.Contains(view) || _outOfStackWindows.Contains(view))
            {
                view.ViewModel.Close();
            }
        }
    }
}
