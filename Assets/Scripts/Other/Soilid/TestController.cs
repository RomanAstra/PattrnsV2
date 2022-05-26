using UnityEngine;

namespace Other.Soilid
{
    internal sealed class TestController
    {
        private readonly Transform _bonus;

        public TestController(Transform bonus)
        {
            _bonus = bonus;
        }
        
        public void Update()
        {
            Debug.LogError(Time.frameCount);
            _bonus.RotateAround(_bonus.position, _bonus.up, Time.deltaTime * 90f);
        }
    }
}
