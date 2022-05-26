using UnityEngine;

namespace BehavioralPatterns.TemplateMethod.ExampleFirst
{
    public sealed class Gb : Site
    {
        protected override void DrawHeader()
        {
            Debug.LogError("------------");
        }

        protected override void DrawBody()
        {
            Debug.LogError("+++++++++++");
        }

        protected override void DrawFooter()
        {
            Debug.LogError("================");
        }
    }
}
