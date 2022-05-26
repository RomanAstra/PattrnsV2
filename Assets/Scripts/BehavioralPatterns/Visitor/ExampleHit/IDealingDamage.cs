using UnityEngine;

namespace Visitor.ExampleHit
{
    public interface IDealingDamage
    {
        void Visit(Enemy hit, InfoCollision info);
        void Visit(Environment hit, InfoCollision info);
        void Visit(Knight hit, InfoCollision info);
        void Visit(Mob hit, InfoCollision info);
        void Visit(HitImpl hit, InfoCollision info);
    }
}
