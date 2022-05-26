using UnityEngine;

namespace MVVM.ViewManager
{
    public interface ITestViewModel : IViewModel
    {
        string Text { get; }
        Vector3 Position { get; set; }
    }
}
