using UnityEngine;

namespace Asteroids.Builder
{
    public class GameObjectBuilder
    {
        protected GameObject _gameObject;
        
        public GameObjectBuilder() => _gameObject = new GameObject();
        protected GameObjectBuilder(GameObject gameObject) => _gameObject = gameObject;

        public GameObjectVisualBuilder Visual => new (_gameObject);

        public GameObjectPhysicsBuilder Physics => new (_gameObject);
  
        public static implicit operator GameObject(GameObjectBuilder builder)
        {
            return builder._gameObject;
        }
    }
}
