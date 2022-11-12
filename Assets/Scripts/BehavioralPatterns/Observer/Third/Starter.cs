using System.Collections.Generic;
using UnityEngine;

namespace BehavioralPatterns.Observer.Third
{
    internal sealed class Starter : MonoBehaviour
    {
        [SerializeField] private View _view;
        [SerializeField] private Args _args;
        private List<IController> _controllers;

        private void Start()
        {
            var viewInfo = new ViewInfo(_args.ViewHp);
            _view.Inj(viewInfo);
            _controllers = new List<IController>
            {
                new TextController(_view, _args),
                new InstantiateController(_view, _args),
                new RendererController(_view, _args),
                new DamageController(_view, viewInfo)
            };
        }

        private void OnDestroy()
        {
            for (var index = 0; index < _controllers.Count; index++)
            {
                var controller = _controllers[index];
                controller.Dispose();
            }

            _controllers.Clear();
        }
    }
}
