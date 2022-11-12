using System;
using UnityEngine;

namespace Asteroids.First
{
    internal sealed class UnitFactory : IUnitFactory
    {
        private readonly IWeaponFactory _weaponFactory;
        private readonly IStartPosition _startPosition;

        public UnitFactory(IWeaponFactory weaponFactory, IStartPosition startPosition)
        {
            _weaponFactory = weaponFactory;
            _startPosition = startPosition;
        }
        
        public IUnit CreatePlayer(float hp, Vector3 position)
        {
            return new Player(hp, _weaponFactory.CreateWeapon<Gun>(), position);
        }

        public IUnit CreatePlayerImmortal(Vector3 position)
        {
            return CreatePlayer(Single.MaxValue, position);
        }

        public IUnit CreatePlayerInStartPosition(float hp)
        {
            return CreatePlayer(hp, _startPosition.Position);
        }

        public IUnit CreateEnemy(float hp)
        {
            return new Enemy();
        }
    }
}
