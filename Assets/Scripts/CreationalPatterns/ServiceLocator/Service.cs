using UnityEngine;

namespace Asteroids.ServiceLocator
{
    internal sealed class Service : IService
    {
        public static Service Instance = new Service();
        public Service()
        {
            
        }
        public void Test()
        {
            Debug.Log(nameof(Service));
        }
    }
}
