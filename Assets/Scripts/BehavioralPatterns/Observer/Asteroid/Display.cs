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
            death.OnDeathChange += DeathOnOnDeathChange; 
        }

        private void Remove(IDeath death)
        {
            // death.OnDeathChange -= delegate { DeathOnOnDeathChange(death.Name); }; 
        }

        private void DeathOnOnDeathChange(string deathName)
        {
            _text.text = $"Умер {deathName}";
        }
    }
}
