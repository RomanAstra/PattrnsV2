using MVVM.ViewModel;
using UnityEngine;

namespace MVVM.View
{
    internal sealed class Player : MonoBehaviour
    {
        private IPlayerViewModel _viewModel;

        public void Initialize(IPlayerViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            _viewModel.OnTrigger(other.gameObject.GetInstanceID());
        }
    }
}
