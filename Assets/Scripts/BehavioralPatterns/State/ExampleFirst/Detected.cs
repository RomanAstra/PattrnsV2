using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    internal sealed class Detected : State
    {
        private readonly Transform _enemy;

        public Detected(Transform enemy)
        {
            _enemy = enemy;
        }

        public override void Handle(Player player)
        {
            Debug.Log(_enemy.name);
        }
    }
}
