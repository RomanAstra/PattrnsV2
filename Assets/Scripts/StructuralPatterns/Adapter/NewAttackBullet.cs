using UnityEngine;

namespace Asteroids.Adapter
{
    internal sealed class NewAttackBullet : IFire
    {
        private readonly IAttack _attack = new AttackBullet();
        
        public void Fire(Vector3 position)
        {
            _attack.Attack(position);
        }
    }
}
