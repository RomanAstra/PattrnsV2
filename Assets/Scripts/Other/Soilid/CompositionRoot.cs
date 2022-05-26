using System;
using System.Collections.Generic;
using UnityEngine;

namespace Other.Soilid
{
    internal sealed class CompositionRoot : MonoBehaviour
    {
        private TestController _testController;
        private readonly List<TestController> _list = new List<TestController>(8);
        public event Action OnUpdate = delegate {  };
        public BonusView _bonus;
        
        private void Start()
        {
            _testController = new TestController(_bonus.transform);
            _list.Add(_testController);
            new MouseDownController(_bonus);
        }

        private void Update()
        {
            for (var i = 0; i < _list.Count; i++)
            {
                _list[i].Update();
            }
            OnUpdate.Invoke();
        }
    }
}
