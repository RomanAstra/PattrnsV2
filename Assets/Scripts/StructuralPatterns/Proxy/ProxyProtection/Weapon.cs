using UnityEngine;

namespace Asteroids.Proxy.ProxyProtection
{
    public sealed class Weapon : IWeapon
    {
        private readonly Rigidbody _bullet;
        private readonly Transform _positionBarrel;
        private readonly float _force;
        private readonly float _timeToDestroy = 10.0f;

        public Weapon(Rigidbody bulletPrefab, Transform positionBarrel, float force)
        {
            _bullet = bulletPrefab;
            _positionBarrel = positionBarrel;
            _force = force;
        }
        
        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet, _positionBarrel.position, Quaternion.identity);
            bullet.AddForce(_positionBarrel.forward * _force);
            Object.Destroy(bullet.gameObject, _timeToDestroy);
        }
    }
}
