namespace MVVM.ViewManager
{

    public interface IView
    {
        IViewModel ViewModel { get; }
        void Show();
        void Hide();
        void Unfocus();
        void Focus();
    }
    
    public interface IView<in T> : IView where T : IViewModel
    {
        void Initialize(T viewModel);
    }
}
