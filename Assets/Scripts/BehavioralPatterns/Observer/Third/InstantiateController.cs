using UnityEngine;

namespace BehavioralPatterns.Observer.Third
{
    internal sealed class InstantiateController : IController
    {
        private readonly View _view;
        private readonly Args _countEnemies;
        private readonly Rigidbody _prefab;

        public InstantiateController(View view, Args args)
        {
            _view = view;
            _countEnemies = args;
            _view.OnTriggerEnterChange += ViewOnOnTriggerEnterChange;
            _prefab = Resources.Load<Rigidbody>("Cylinder");
        }

        private void ViewOnOnTriggerEnterChange(Renderer obj)
        {
            for (int i = 0; i < _countEnemies.CountEnemies; i++)
            {
                Object.Instantiate(_prefab, new Vector3(i, i, 0), Quaternion.identity);
            }
        }

        public void Dispose()
        {
            _view.OnTriggerEnterChange -= ViewOnOnTriggerEnterChange;
        }
    }
}
