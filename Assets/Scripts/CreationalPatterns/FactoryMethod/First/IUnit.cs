using UnityEngine;

namespace Asteroids.First
{
    internal interface IUnit
    {
        float Hp { get; }
        IWeapon Weapon { get; }
        Vector3 Position { get; }
    }
}
