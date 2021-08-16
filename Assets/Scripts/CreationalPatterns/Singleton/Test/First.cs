using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Asteroids.Singleton.Test
{
    [RequireComponent(typeof(InputField))]
    internal sealed class First : MonoBehaviour
    {
        private InputField _inputField;
        private IText _text;

        private void Start()
        {
            _inputField = GetComponent<InputField>();
            _inputField.onValueChanged.RemoveAllListeners();
            _inputField.onValueChanged.AddListener(Call);
        }

        private void Call(string arg0)
        {
            _text.Text = arg0;
        }

        public void DependencyInjection(IText text)
        {
            _text = text;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.UnloadSceneAsync(0, UnloadSceneOptions.None);
                SceneManager.LoadScene(1, LoadSceneMode.Additive);
            }
        }
    }
}
