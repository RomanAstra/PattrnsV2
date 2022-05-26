using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class StateTest : MonoBehaviour
    {
        private void Start ()
        {
            Player c = new Player(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}
