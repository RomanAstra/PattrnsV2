using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Proxy.ProxyProtection
{
    public sealed class WeaponProxy : IWeapon
    {
        private readonly IWeapon _weapon;
        private readonly UnlockWeapon _unlockWeapon;
        private readonly Text _text;

        public WeaponProxy(IWeapon weapon, UnlockWeapon unlockWeapon, Text text)
        {
            _weapon = weapon;
            _unlockWeapon = unlockWeapon;
            _text = text;
        }

        public void Fire()
        {
            _text.gameObject.SetActive(!_unlockWeapon.IsUnlock);
            if (_unlockWeapon.IsUnlock)
            {
                _weapon.Fire();
            }
            else
            {
                _text.text = "Weapon is lock";
            }
        }
    }
}
