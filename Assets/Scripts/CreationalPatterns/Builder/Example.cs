using System.Text;
using UnityEngine;

namespace Asteroids.Builder
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        
        private void Start()
        {
            #region MyRegion

            // StringBuilder sb;
            // sb.Append("");

            #endregion
            
            var gameObjectBuilder = new GameObjectBuilder();
            GameObject player = gameObjectBuilder
                .Visual
                .Name("Roman")
                .Sprite(_sprite)
                .Physics
                .BoxCollider2D()
                .Rigidbody2D(6.0f);
        }
        
    }
}
