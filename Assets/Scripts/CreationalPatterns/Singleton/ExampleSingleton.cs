using UnityEngine;

namespace Asteroids.Singleton
{
    internal sealed class ExampleSingleton : MonoBehaviour
    {
        private void Start()
        {
            Services.Instance.Test();
            TestSingletonMonoBehaviour.Instance.Test();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var objectsInRadius in Services.Instance.GetObjectsInRadius(transform.position, 50.0f))
                {
                    Debug.Log(objectsInRadius.name);
                }
            }
        }
    }
}
