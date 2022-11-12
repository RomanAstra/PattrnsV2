using System;
using UnityEngine;

namespace MVVM.ViewManager
{
    class TestViewModel : ITestViewModel
    {
        public string Text { get; }
        public Vector3 Position { get; set; }
        public void Close()
        {
            throw new NotImplementedException();
        }

        public event Action<IViewModel> Closed;
    }
}
