using UnityEngine;

namespace Asteroids.First
{
    internal sealed class Enemy : IUnit
    {
        public float Hp { get; }
        public IWeapon Weapon { get; }
        public Vector3 Position { get; }
    }
}
