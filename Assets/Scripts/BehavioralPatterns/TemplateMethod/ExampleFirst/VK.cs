using UnityEngine;

namespace BehavioralPatterns.TemplateMethod.ExampleFirst
{
    public sealed class VK : Site
    {
        protected override void DrawHeader()
        {
            Debug.Log("------------");
        }

        protected override void DrawBody()
        {
            Debug.Log("+++++++++++");
        }

        protected override void DrawFooter()
        {
            Debug.Log("================");
        }
    }
}
