using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class Inspection : State
    {
        public override void Handle(Player player)
        {
            if (player.Hp > 0)
            {
                player.Renderer.material.color = Color.green;
            }
        }
    }
}
