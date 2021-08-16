using System;
using UnityEngine;

namespace Optimization
{
    public sealed class ExampleSecond : MonoBehaviour
    {
        private Renderer myRenderer;

        private void Start()
        {
            myRenderer = GetComponent<Renderer>();
        }

        private void Update()
        {
            UpdateTransformPosition();

            if (myRenderer.isVisible)
            {
                UpdateAnimations();
            }
        }

        private void OnBecameInvisible()
        {
            UpdateTransformPosition();
        }

        private void UpdateAnimations()
        {
           //...
        }

        private void UpdateTransformPosition()
        {
           //...
        }
    }
}
