using UnityEngine;

namespace Asteroids.First
{
    internal sealed class UnitFactory : IUnitFactory
    {
        private readonly IWeaponFactory _weaponFactory;

        public UnitFactory(IWeaponFactory weaponFactory)
        {
            _weaponFactory = weaponFactory;
        }
        
        public IUnit CreatePlayer(float hp, Vector3 position)
        {
            return new Player(hp, _weaponFactory.CreateWeapon<Gun>(), position);
        }

        public IUnit CreateEnemy(float hp, Vector3 position)
        {
            return new Enemy();
        }
    }
}
