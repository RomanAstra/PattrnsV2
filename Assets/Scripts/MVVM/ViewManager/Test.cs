using UnityEngine;

namespace MVVM.ViewManager
{
    internal sealed class Test
    {
        private readonly ViewManager _viewManager;

        public Test(ViewManager viewManager)
        {
            _viewManager = viewManager;
        }

        private void First()
        {
            _viewManager.Register(Object.FindObjectOfType<View>());
        }

        private void Second()
        {
            _viewManager.ShowWindow(new TestViewModel());
        }
    }
}
