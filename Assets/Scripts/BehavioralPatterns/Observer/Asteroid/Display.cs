using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BehavioralPatterns.Observer.Asteroid
{
    internal class Display : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private List<IDeath> _deaths;

        private void Add(IDeath death)
        {
            death.OnDeathChange += () =>
            {
                DeathOnOnDeathChange(death.Name);
            }; 
        }

        private void DeathOnOnDeathChange(string deathName)
        {
            _text.text = $"Умер {deathName}";
        }
    }
}
