using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    internal sealed class Died : State
    {
        public override void Handle(Player player)
        {
            player.Renderer.material.color = Color.black;
        }
    }
}
