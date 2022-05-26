﻿using UnityEngine;


namespace Visitor.ExampleHit
{
    public sealed class ConsoleDisplay : IDealingDamage
    {
        public void Visit(Enemy hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Enemy)} - {info.Damage}");
        }

        public void Visit(Environment hit, InfoCollision info)
        {
            Debug.LogWarning($"{nameof(Environment)} - {info.Damage}");
        }

        public void Visit(Knight hit, InfoCollision info)
        {
            Debug.LogError($"{nameof(Knight)} - {info.Damage}");
        }

        public void Visit(Mob hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Mob)} - {info.Damage}");
        }

        public void Visit(HitImpl hit, InfoCollision info)
        {
            Debug.Log($"Destroy {hit.name}");
        }
    }
}
