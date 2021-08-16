using UnityEngine;

namespace Asteroids.First
{
    internal sealed class Player : IUnit
    {
        public float Hp { get; }
        public IWeapon Weapon { get; }
        public Vector3 Position { get; }

        public Player(float hp, IWeapon weapon, Vector3 position)
        {
            Hp = hp;
            Weapon = weapon;
            Position = position;
        }
    }
}
