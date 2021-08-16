using Asteroids.Builder;
using UnityEngine;

namespace Asteroids
{
    public sealed class AsteroidFactory : IEnemyFactory
    {
        private readonly GameObjectBuilder _gameObjectBuilder;

        public AsteroidFactory(GameObjectBuilder gameObjectBuilder)
        {
            _gameObjectBuilder = gameObjectBuilder;
        }
        
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
        
            enemy.DependencyInjectHealth(hp);
        
            return enemy;
        }
    }
}
