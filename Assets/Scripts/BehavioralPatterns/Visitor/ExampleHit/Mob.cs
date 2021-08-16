using UnityEngine.UI;

namespace Visitor.ExampleHit
{
    public sealed class Mob : Hit
    {
        public Text Text;
        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }
    }
}
