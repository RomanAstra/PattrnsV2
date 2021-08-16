using UnityEngine;

namespace Asteroids.First
{
    internal interface IUnitFactory
    {
        IUnit CreatePlayer(float hp, Vector3 position);
        IUnit CreateEnemy(float hp, Vector3 position);
    }
}
