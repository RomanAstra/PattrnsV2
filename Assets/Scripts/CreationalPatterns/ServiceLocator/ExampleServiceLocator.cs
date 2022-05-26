using System;
using UnityEngine;

namespace Asteroids.ServiceLocator
{
    internal sealed class ExampleServiceLocator : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.SetService<IService>(new ServiceSecond());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ServiceLocator.SetService<IService>(new Service());
            }
        }

        private void Start()
        {
            Service.Instance.Test();
            ServiceLocator.Resolve<IService>().Test();
            ServiceLocatorMonoBehaviour.GetService<CharacterController>();
        }

        private void Start2()
        {
            Service.Instance.Test();
            ServiceLocator.Resolve<IService>().Test();
            ServiceLocatorMonoBehaviour.GetService<CharacterController>();
        }
    }
}
