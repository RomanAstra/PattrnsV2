using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class StateTest : MonoBehaviour
    {
        private const float ACTIVE_DIS = 5;
        private const float ACTIVE_ANG = 35;
        [SerializeField] private float _hp;
        [SerializeField] private Transform _playerView;
        [SerializeField] private Transform[] _enems;
        private Player _player;

        private void Start ()
        {
            _player = new Player(_playerView, new Inspection(), _hp);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _player.Hp -= 10.0f;
            }
            foreach (var enemy in _enems)
            {
                if (Vision(_playerView, enemy))
                {
                    var detected = new Detected(enemy);
                    _player.State = detected;
                }
            }
        }

        public bool Vision(Transform player, Transform target)
        {
            return Distance(player, target) && Angle(player, target) && !CheckBloked(player, target);
        }

        private bool CheckBloked(Transform player, Transform target)
        {
            if (!Physics.Linecast(player.position, target.position, out var hit)) return true;
            return hit.transform != target;
        }

        private bool Angle(Transform player, Transform target)
        {
            var angle = Vector3.Angle(target.position - player.position, player.forward);
            return angle <= ACTIVE_ANG;
        }

        private bool Distance(Transform player, Transform target)
        {
            return (player.position - target.position).sqrMagnitude <= ACTIVE_DIS * ACTIVE_DIS;
        }
    }
}
