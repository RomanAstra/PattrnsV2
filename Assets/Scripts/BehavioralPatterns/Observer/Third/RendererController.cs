using UnityEngine;

namespace BehavioralPatterns.Observer.Third
{
    internal sealed class RendererController : IController
    {
        private readonly View _view;
        private readonly Args _args;

        public RendererController(View view, Args args)
        {
            _view = view;
            _args = args;
            _view.OnTriggerEnterChange += ViewOnOnTriggerEnterChange;
        }

        private void ViewOnOnTriggerEnterChange(Renderer obj)
        {
            obj.material.color = _args.ColorPlayer;
        }

        public void Dispose()
        {
            _view.OnTriggerEnterChange -= ViewOnOnTriggerEnterChange;
        }
    }
}
