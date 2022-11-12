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

        private void OnTriggerEnter(Collider other)
        {
        }

        public IViewModel ViewModel => _viewModel;

        public void Initialize(ITestViewModel viewModel)
        {
            _viewModel = viewModel;
            _text.text = viewModel.Text;
            int t = 0;
            object o = t;
            //Debug.Log(((int)(object)(int)o).ToString());
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

        public void Unfocus()
        {
            throw new NotImplementedException();
        }

        public void Focus()
        {
            throw new NotImplementedException();
        }
    }
}
