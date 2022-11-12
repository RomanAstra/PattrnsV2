using System;
using MVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;

namespace MVVM.View
{
    internal sealed class ApplyDamageView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _damage;
        private IHpViewModel _hpViewModel;

        public void Initialize(IHpViewModel hpViewModel)
        {
            _hpViewModel = hpViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _hpViewModel.ApplyDamage(_damage));
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out Rigidbody t))
            {
                _hpViewModel.CollisionRigidbody();
            }
            if (collision.gameObject.TryGetComponent(out MeshRenderer t2))
            {
                _hpViewModel.CollisionMeshRenderer();
            }

        }
    }
}
