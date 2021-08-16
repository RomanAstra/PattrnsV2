using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVM.ViewManager
{
    internal sealed class ViewManager
    {
        private readonly Dictionary<Type, IView> _views = new Dictionary<Type, IView>();
        
        public void Register<T>(IView<T> view) where T : class, IViewModel
        {
            if (view == null)
            {
                throw new ArgumentNullException();
            }

            _views.Add(typeof(T), view);
        }

        public IView<T> ShowWindow<T>(T viewModel) where T : class, IViewModel
        {
            var view = GetView<T>();

            view.Initialize(viewModel);
            return view;
        }

        private IView<T> GetView<T>() where T : class, IViewModel
        {
            var type = typeof(T);
            if (_views.ContainsKey(type))
            {
                var view = (IView<T>) _views[type];
                return view;
            }
            else
            {
                var view = (IView<T>) _views.First(a => a.Key.IsSubclassOf(type)).Value;
                return view;
            }
        }
    }
}
