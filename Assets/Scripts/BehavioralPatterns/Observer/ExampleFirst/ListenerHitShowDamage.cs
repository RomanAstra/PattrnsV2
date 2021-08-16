using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BehavioralPatterns.Observer.ExampleFirst
{
    public sealed class ListenerHitShowDamage
    {
        private readonly List<IHit> _hits = new List<IHit>(8);
        
        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnOnHitChange;
            _hits.Add(value);
        }

        public void Remove(IHit value)
        {
            var firstOrDefault = _hits.FirstOrDefault(hit => hit == value);
            firstOrDefault.OnHitChange -= ValueOnOnHitChange;
            _hits.Remove(firstOrDefault);
        }

        private void ValueOnOnHitChange(float damage)
        {
            Debug.Log(damage);
            
            Test += OnTest;
        }

        private void OnTest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public event EventHandler Test;
    }
}
