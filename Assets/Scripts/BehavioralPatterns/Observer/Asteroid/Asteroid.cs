using System;

namespace BehavioralPatterns.Observer.Asteroid
{
    internal sealed class Asteroid : IDeath
    {
        private float _hp;
        public string Name { get; }
        public event Action OnDeathChange;

        public float Hp
        {
            set
            {
                _hp = value;
                if (_hp <= 0)
                {
                    OnDeathChange?.Invoke();
                }
            }
        }
    }
}
