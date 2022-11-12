using System;
using TMPro;
using UnityEngine;

namespace BehavioralPatterns.Observer.Third
{
    internal sealed class View : MonoBehaviour
    {
        [SerializeField] private TextMesh _textMesh;
        private Renderer _renderer;
        private ViewInfo _viewInfo;
        public event Action<Renderer> OnTriggerEnterChange;

        public void Inj(ViewInfo viewInfo)
        {
            _viewInfo = viewInfo;
            _viewInfo.OnHpChange += OnHpChange;
            OnHpChange();
        }

        private void OnHpChange()
        {
            _textMesh.text = _viewInfo.Hp.ToString();
        }

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEnterChange?.Invoke(_renderer);
        }

        private void OnDestroy()
        {
            _viewInfo.OnHpChange -= OnHpChange;
        }
    }
}
