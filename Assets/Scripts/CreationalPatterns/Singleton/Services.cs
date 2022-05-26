using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Asteroids.Singleton
{
    public sealed class Services
    {
        private readonly Collider[] _collidedObjects = new Collider[10];
        private readonly List<Collider> _triggeredObjects = new ();
        
        private static readonly Lazy<Services> _instance = 
            new Lazy<Services>(() => new Services(), 
                LazyThreadSafetyMode.ExecutionAndPublication);
        
        public static Services Instance => _instance.Value;
        
        private Services()
        {
        }

        public void Test()
        {
             Debug.Log(nameof(Services));
        }

        public List<Collider> GetObjectsInRadius(Vector3 position, float radius, int layerMask = 0)
        {
            _triggeredObjects.Clear();
            Collider trigger;

            var collidersCount = Physics.OverlapSphereNonAlloc(position, radius, 
                _collidedObjects);
            
            for (var i = 0; i < collidersCount; i++)
            {
                trigger = _collidedObjects[i];

                if (trigger != null && !_triggeredObjects.Contains(trigger))
                {
                    _triggeredObjects.Add(trigger);
                }
            }

            return _triggeredObjects;
        }

        public void Next()
        {
            
        }
    }
}
