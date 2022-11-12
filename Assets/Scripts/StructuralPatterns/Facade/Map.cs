namespace Asteroids.Facade
{
    internal sealed class Map
    {
        private readonly Player _player;
        public int SizeMap { get; }

        public string PlayerName => _player.PlayerName;

        public Map(int sizeMap, Player player)
        {
            SizeMap = sizeMap;
            _player = player;
        }
    }
}
