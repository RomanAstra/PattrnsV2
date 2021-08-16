namespace MVVM.ViewManager
{

    public interface IView
    {
        IViewModel ViewModel { get; }
        void Show();
        void Hide();
    }
    
    public interface IView<in T> : IView where T : IViewModel
    {
        void Initialize(T viewModel);
    }
}
