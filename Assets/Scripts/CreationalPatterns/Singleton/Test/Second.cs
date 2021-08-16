using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Singleton.Test
{
    internal sealed class Second : MonoBehaviour
    {
        public void DependencyInjection(IText text)
        {
            GetComponent<Text>().text = text.Text;
        }
    }
}
