using System;
using UnityEngine;

namespace Asteroids.Singleton
{
    internal sealed class TestSingletonMonoBehaviour : SingletonMonoBehaviour<TestSingletonMonoBehaviour>
    {
        public void Test()
        {
            Debug.Log(nameof(TestSingletonMonoBehaviour));
            Services.Instance.Test();
        }

        public static TestSingletonMonoBehaviour InstanceBad;

        private void Start()
        {
            InstanceBad = this;
        }
    }
}
