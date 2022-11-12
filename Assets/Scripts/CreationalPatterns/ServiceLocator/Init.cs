using UnityEngine;

namespace Asteroids.ServiceLocator
{
    internal sealed class Init : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.SetService<IService>(new Service());
            // ServiceLocator.SetService<IService>(new ServiceSecond());
        }
    }
}
