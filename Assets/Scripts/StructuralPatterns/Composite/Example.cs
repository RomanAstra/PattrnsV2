using UnityEngine;

namespace Asteroids.Composite
{
    internal sealed class Example : MonoBehaviour
    {
        private Unit _unit;
        
        private void Start()
        {
            IAttack attack = new Unit();
            IAttack attack2 = new Unit();
            Detachment attacks = new Detachment();
            attacks.AddUnit(attack);
            attacks.AddUnit(attack2);

            attacks.Attack(_unit); 
            
            attacks.RemoveUnit(attack);
        }
    }
}
