using UnityEngine;

namespace BehavioralPatterns.Observer.Third
{
    internal sealed class DamageController : IController
    {
        private readonly View _view;
        private readonly ViewInfo _args;
        private readonly float _hp;

        public DamageController(View view, ViewInfo args)
        {
            _view = view;
            _args = args;
            _view.OnTriggerEnterChange += ViewOnOnTriggerEnterChange;
        }

        private void ViewOnOnTriggerEnterChange(Renderer obj)
        {
            _args.Hp -= 1.0f;
            if (_args.Hp <= 0)
            {
                _view.gameObject.AddComponent<Rigidbody>();
            }
        }

        public void Dispose()
        {
            _view.OnTriggerEnterChange -= ViewOnOnTriggerEnterChange;
        }
    }
}
