using UnityEngine;

namespace Asteroids.Facade
{
    internal sealed class Game
    {
        private readonly Map _map;

        public Game(Map map)
        {
            _map = map;
        }

        public void Start()
        {
            Debug.LogWarning($"Start Game with PlayerName: {_map.PlayerName} and SizeMap: {_map.SizeMap}");
        }
    }
}
