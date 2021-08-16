using UnityEngine;

namespace Asteroids.First
{
    class Weapon : IWeapon
    {
        private readonly Rigidbody _prefab;

        public Weapon(Rigidbody prefab)
        {
            _prefab = prefab;
        }
        
        public void Fire()
        {
            var bullet = Object.Instantiate(_prefab);
            bullet.AddForce(Vector3.forward);
        }
    }
}
