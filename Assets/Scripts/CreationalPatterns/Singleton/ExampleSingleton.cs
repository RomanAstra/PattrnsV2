using UnityEngine;

namespace Asteroids.Singleton
{
    internal sealed class ExampleSingleton : MonoBehaviour
    {
        private void Start()
        {
            // new Services();
            Services.Instance.Test();
            TestSingletonMonoBehaviour.Instance.Test();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var colliders = Services.Instance
                    .GetObjectsInRadius(transform.position, 500.0f);
                foreach (var objectsInRadius in colliders)
                {
                    Debug.LogError(objectsInRadius.name);
                }
            }
        }
    }
}
