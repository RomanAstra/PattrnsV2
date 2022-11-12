using System.Collections.Generic;

namespace Asteroids.Composite
{
    internal sealed class Detachment : IAttack
    {
        private List<IAttack> _attacks = new();

        public void AddUnit(IAttack attack)
        {
            _attacks.Add(attack);
        }

        public void RemoveUnit(IAttack attack)
        {
            _attacks.Remove(attack);
        }
        
        public void Attack(Unit unit)
        {
            foreach (var attack in _attacks)
            {
                attack.Attack(unit);
            }
        }
    }
}
