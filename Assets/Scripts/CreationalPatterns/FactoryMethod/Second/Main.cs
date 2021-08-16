using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Second
{
    internal sealed class Main : MonoBehaviour
    {
        private Point _point;

        public static Main CreateMain(Point point)
        {
            var mainObject = new GameObject(nameof(Main)).AddComponent<Main>();
            mainObject._point = point;

            return mainObject;

            // Task.Factory.StartNew()
        }
    }
}
