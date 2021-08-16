using UnityEngine;

namespace Visitor.ExampleHit
{
    public sealed class Enemy : Hit
    {
        public TextMesh TextMesh;
        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }
    }
}
