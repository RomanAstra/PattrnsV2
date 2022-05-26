namespace Visitor.ExampleHit
{
    public class HitImpl : Hit
    {
        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }
    }
}
