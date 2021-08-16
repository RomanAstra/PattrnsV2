using UnityEngine;

namespace Asteroids.Mediator.First
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private View _view;

        private void Awake()
        {
            new Controller(new Model(100), _view).Show();
        }
    }
}
