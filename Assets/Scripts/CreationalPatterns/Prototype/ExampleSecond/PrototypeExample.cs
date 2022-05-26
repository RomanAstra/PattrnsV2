using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Prototype.ExampleSecond
{
    internal sealed class PrototypeExample : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _lifeTime;
        [SerializeField] private float _force;
        
        private float _hp;

        private void Start()
        {
            if (_button is { })
            {
                _button.onClick.AddListener(() =>
                {
                    var prototypeExample = Clone();
                    Destroy(prototypeExample.gameObject, _lifeTime);
                });
            }
        }
        
        public PrototypeExample Clone()
        {
            PrototypeExample newObject = default;
            newObject = new GameObject(name).AddComponent<PrototypeExample>();
            if (gameObject.TryGetComponent<Rigidbody>(out var rigidbody))
            {
                var rigidbodyNew = newObject.gameObject.AddComponent<Rigidbody>();
                rigidbodyNew.velocity = rigidbody.velocity;
                rigidbodyNew.AddForce(Random.insideUnitSphere * _force);
                //.....
            }
            if (gameObject.TryGetComponent<SpriteRenderer>(out var spriteRenderer))
            {
                var spriteRendererNew = newObject.gameObject.AddComponent<SpriteRenderer>();
                spriteRendererNew.sprite = spriteRenderer.sprite;
                //.....
            }
            if (gameObject.TryGetComponent<BoxCollider>(out var boxCollider))
            {
                var boxColliderNew = newObject.gameObject.AddComponent<BoxCollider>();
                boxColliderNew.size = boxCollider.size;
                //.....
            }
            if (gameObject.TryGetComponent<MeshRenderer>(out var meshRenderer))
            {
                var meshRendererNew = newObject.gameObject.AddComponent<MeshRenderer>();
                meshRendererNew.material = meshRenderer.material;
                //.....
            }
            if (gameObject.TryGetComponent<MeshFilter>(out var meshFilter))
            {
                var meshFilterNew = newObject.gameObject.AddComponent<MeshFilter>();
                meshFilterNew.mesh = meshFilter.mesh;
                //.....
            }

            newObject._hp = _hp;
            // newObject._button = _button;
            newObject.transform.position = new Vector3(transform.position.x, 
                transform.position.y + 1, transform.position.z);
            return newObject;
        }
    }
}
