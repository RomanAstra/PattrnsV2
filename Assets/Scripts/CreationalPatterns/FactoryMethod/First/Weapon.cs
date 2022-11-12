using ObjectPool;
using UnityEngine;

namespace Asteroids.First
{
    public sealed class Weapon : IWeapon
    {
        private readonly Rigidbody _prefabBullet;
        private readonly IViewServices _viewServices;

        public Weapon(Rigidbody prefabBullet, IViewServices viewServices)
        {
            _prefabBullet = prefabBullet;
            _viewServices = viewServices;
        }
        
        public void Fire()
        {
            var bullet = _viewServices.Instantiate<Rigidbody>(_prefabBullet.gameObject);
            bullet.AddForce(Vector3.forward);
            _viewServices.Destroy(bullet.gameObject);
        }
    }


}
