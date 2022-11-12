namespace Asteroids.Facade
{
    internal sealed class Player
    {
        public string PlayerName { get; }

        public Player(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
