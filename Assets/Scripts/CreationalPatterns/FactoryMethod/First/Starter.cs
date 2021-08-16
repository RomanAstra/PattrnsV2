using System;
using UnityEngine;

namespace Asteroids.First
{
    internal sealed class Starter : MonoBehaviour
    {
        private IUnitFactory _unitFactory;

        public void SetUnitFactory(IUnitFactory unitFactory)
        {
            _unitFactory = unitFactory;
        }
        
        private void Start()
        {
            IUnit player = _unitFactory.CreatePlayer(100.0f, Vector3.zero);
            // IUnit player2 = new Enemy();
            string name = "Roman";
        }
    }
}
