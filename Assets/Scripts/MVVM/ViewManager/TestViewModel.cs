using UnityEngine;

namespace MVVM.ViewManager
{
    class TestViewModel : ITestViewModel
    {
        public string Text { get; }
        public Vector3 Position { get; set; }
    }
}
