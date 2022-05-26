using System.Collections.Generic;
using UnityEngine;

namespace Optimization
{
    public sealed class ExampleThree : MonoBehaviour
    {
        private List<int> _myList = new List<int>();

        private void Update()
        {
            _myList.Clear();
            _myList = new List<int>();
            PopulateList(_myList);
        }

        private void PopulateList(List<int> list)
        {
            //...
        }
    }
}
