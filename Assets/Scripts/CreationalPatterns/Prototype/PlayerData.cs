using System;

namespace Asteroids.Prototype
{
    [Serializable]
    internal sealed class PlayerData : ICloneable
    {
        public float Speed;
        public Hp Hp;

        public override string ToString()
        {
            return $"Speed {Speed} Hp {Hp}";
        }

        public object Clone()
        {
            return new PlayerData
            {
                Speed = Speed,
                Hp = new Hp
                {
                    CurrentHP = Hp.CurrentHP,
                    MaxHP = Hp.MaxHP,
                }
            };
            return MemberwiseClone();
        }
    }
}
