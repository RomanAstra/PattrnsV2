using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Mediator.First
{
    internal sealed class View : MonoBehaviour
    {
        private Text _text;

        private void Awake()
        {
            _text = GetComponent<Text>();
        }

        public int Text
        {
            set => _text.text = $"{value:0.0}";
        }
    }
}
