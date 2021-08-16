using UnityEngine;

namespace Asteroids.Prototype.ExampleSecond
{
    internal sealed class PrototypeExample : MonoBehaviour
    {
        private float _hp;
        private bool TreGetRigidbody(out Rigidbody rigidbody)
        {
            return TryGetComponent(out rigidbody);
        }
        
        public PrototypeExample Clone()
        {
            PrototypeExample newObject = default;
            newObject = new GameObject(name).AddComponent<PrototypeExample>();
            if (TreGetRigidbody(out var oldRigidbody))
            {
                var rigidbody = newObject.gameObject.AddComponent<Rigidbody>();
                rigidbody.velocity = oldRigidbody.velocity;
            }

            newObject._hp = _hp;
            return newObject;
        }
    }
}
