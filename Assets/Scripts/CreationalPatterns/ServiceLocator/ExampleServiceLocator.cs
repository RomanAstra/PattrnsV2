using System;
using UnityEngine;

namespace Asteroids.ServiceLocator
{
    internal sealed class ExampleServiceLocator : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ServiceLocatorMonoBehaviour.GetService<CharacterController>();
                ServiceLocator.Resolve<IService>().Test();
            }
        }
    }
}
