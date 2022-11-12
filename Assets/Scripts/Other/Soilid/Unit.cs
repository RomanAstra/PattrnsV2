using UnityEngine;

namespace Other.Soilid
{
    internal abstract class Unit
    {
        public float Hp { get; set; } 
        public float Defense { get; }
        public Vector3 Position { get; set; }

        public virtual void GetDamage(float damage)
        {
            if (Defense > damage)
            {
                return;
            }

            Hp -= damage - Defense;
        }
    }
}
