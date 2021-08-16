using UnityEngine;

namespace Asteroids
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        [SerializeField] private GameObject _prefab;
        
        private void Start()
        {
            new GameObject().SetName("Enemy").AddBoxCollider2D().
                AddBoxCollider2D().AddRigidbody2D(5.0f).AddSprite(_sprite);

            // Resources.Load<Asteroid>("Asteroid")
            // _prefab.AddRigidbody2D(0.6f);
        }
    }
}
