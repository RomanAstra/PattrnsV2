using UnityEngine;

namespace Asteroids.ServiceLocator
{
    internal sealed class ServiceSecond : IService
    {
        public void Test()
        {
            Debug.LogWarning(nameof(ServiceSecond));
        }
    }
}
