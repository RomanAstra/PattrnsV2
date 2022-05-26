using UnityEngine;

namespace Other.Soilid
{
    internal sealed class MouseDownController
    {
        private readonly BonusView _bonusView;

        public MouseDownController(BonusView bonusView)
        {
            _bonusView = bonusView;
            _bonusView.OnMouseDownChange += BonusViewOnOnMouseDownChange;
        }

        private void BonusViewOnOnMouseDownChange()
        {
            Debug.LogWarning(3454345);
        }

        ~MouseDownController()
        {
            _bonusView.OnMouseDownChange -= BonusViewOnOnMouseDownChange;
        }
    }
}
