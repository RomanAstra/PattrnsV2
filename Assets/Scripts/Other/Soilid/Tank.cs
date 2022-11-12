using UnityEngine;

namespace Other.Soilid
{
    internal sealed class Tank : Unit
    {
    }


    internal class Spawner
    {
        public Spawner(Unit tank)
        {
            tank.Position = Vector3.one;
        }
    }

    internal class Main
    {
        private void Start()
        {
            new Spawner(new Doctor());
            new Spawner(new Tank());
        }
    }
}
