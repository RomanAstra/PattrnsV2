using System;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Proxy.ProxyProtection
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Rigidbody _prefabBullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private Text _text;
        [SerializeField, Range(0.0f, 900000.0f)] private float _force;
        private Weapon _weapon;
        private WeaponProxy _weaponProxy;
        private UnlockWeapon _unlockWeapon;

        private void Start()
        {
            _unlockWeapon = new UnlockWeapon(false);
            _weapon = new Weapon(_prefabBullet, _barrel, _force);
            _weaponProxy = new WeaponProxy(_weapon, _unlockWeapon, _text);
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                _weaponProxy.Fire();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _unlockWeapon.IsUnlock = !_unlockWeapon.IsUnlock;
            }
        }
    }
}
