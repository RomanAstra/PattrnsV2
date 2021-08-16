using UnityEngine;

namespace MVVM.ViewManager
{
    public interface ITestViewModel : IViewModel
    {
        string Text { get; }
        Vector3 Position { get; set; }
    }

    class TestViewModel : ITestViewModel
    {
        public string Text { get; }
        public Vector3 Position { get; set; }
    }
}
