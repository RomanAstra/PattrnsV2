using System;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

namespace BehavioralPatterns.Observer.Third
{
    internal sealed class TextController : IController
    {
        private readonly View _view;
        private readonly Args _args;
        private readonly TMP_Text _text;

        public TextController(View view, Args args)
        {
            _view = view;
            _args = args;
            _text = Object.FindObjectOfType<TMP_Text>();
            _view.OnTriggerEnterChange += ViewOnOnTriggerEnterChange;
        }

        private void ViewOnOnTriggerEnterChange(Renderer obj)
        {
            if (!_args.IsActive)
            {
                return;
            }

            _text.text = DateTime.UtcNow.ToString();
        }

        public void Dispose()
        {
            _view.OnTriggerEnterChange -= ViewOnOnTriggerEnterChange;
        }
    }
}
