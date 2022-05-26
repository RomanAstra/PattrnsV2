using UnityEngine;

namespace BehavioralPatterns.TemplateMethod.ExampleFirst
{
    public sealed class TemplateMethodTest : MonoBehaviour
    {
        private void Start()
        {
            Site vk = new Gb();
            vk.Draw();
        }
    }
}
