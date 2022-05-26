using UnityEngine;

namespace Asteroids.First
{
    internal sealed class Starter : MonoBehaviour
    {
        [SerializeField] private Transform _playerPosition;
        private IUnitFactory _unitFactory;

        public void SetUnitFactory(IUnitFactory unitFactory)
        {
            _unitFactory = unitFactory;
        }
        
        private void Start()
        {
            IUnit player = _unitFactory.CreatePlayer(100.0f, _playerPosition.position);
            IUnit player2 = _unitFactory.CreatePlayerImmortal(_playerPosition.position);
            IUnit player3 = _unitFactory.CreatePlayerInStartPosition(100.0f);
            IUnit enemy = new Enemy();
        }
    }
}
