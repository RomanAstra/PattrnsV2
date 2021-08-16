using System;
using UnityEngine;
using UnityEngine.UI;

namespace MVVM.ViewManager
{
    internal class View : MonoBehaviour, IView<ITestViewModel>, IUpdate
    {
        [SerializeField] private Text _text;
        [SerializeField] private float _offset;
        private ITestViewModel _viewModel;

        public IViewModel ViewModel => _viewModel;

        public void Initialize(ITestViewModel viewModel)
        {
            _viewModel = viewModel;
            _text.text = viewModel.Text;
        }

        public void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _viewModel.Position = new Vector3(_viewModel.Position.x,
                    _viewModel.Position.y + _offset);
            }
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }

    internal interface IUpdate
    {
        void OnUpdate();
    }
}
