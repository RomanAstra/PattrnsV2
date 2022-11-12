using System;

namespace MVVM.ViewManager
{
    public interface IViewModel
    {
        void Close();
        event Action<IViewModel> Closed;
    }
}
