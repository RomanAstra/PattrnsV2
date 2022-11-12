using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class Player
    {
        private readonly Transform _playerView;
        private float _hp;
        private State _state;

        public Renderer Renderer { get; }

        public Player(Transform playerView, State state, float hp)
        {
            _playerView = playerView;
            Renderer = _playerView.GetComponent<MeshRenderer>();
            _hp = hp;
            State = state;
        }

        public State State
        {
            set
            {
                _state = value;
                _state.Handle(this);
                Debug.Log("State: " + _state.GetType().Name);
            }
        }

        public float Hp
        {
            get => _hp;
            set
            {
                _hp = value;
                if (_hp <= 0)
                {
                    State = new Died();
                }
            }
        }
    }
}
