using UnityEngine;

namespace Asteroids.Composite
{
    internal sealed class Example : MonoBehaviour
    {
        private Unit _unit;
        
        private void Start()
        {
            IAttack attack = new Unit();
            Detachment attacks = new Detachment();
            attacks.AddUnit(attack);

            attack.Attack(_unit);
            attacks.Attack(_unit); 
            
            attacks.RemoveUnit(attack);
        }
    }
}
