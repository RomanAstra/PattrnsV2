using System;

namespace BehavioralPatterns.Observer.Third
{
    internal sealed class ViewInfo
    {
        public event Action OnHpChange;
        private float _hp;

        public ViewInfo(float argsViewHp)
        {
            _hp = argsViewHp;
        }

        public float Hp
        {
            get => _hp;
            set
            {
                _hp = value;
                OnHpChange?.Invoke();
            }
        }
    }
}
