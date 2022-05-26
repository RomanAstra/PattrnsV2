using System;
using UnityEngine;

namespace Other.Soilid
{
    internal sealed class BonusView : MonoBehaviour
    {
        public event Action OnMouseDownChange;
        
        private void OnMouseDown()
        {
            OnMouseDownChange?.Invoke();
        }
    }
}
