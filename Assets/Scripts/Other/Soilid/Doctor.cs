using UnityEngine;

namespace Other.Soilid
{
    internal sealed class Doctor : Unit, ITreatable
    {
        public void Treat(float hp)
        {
            Hp += hp;
        }

        public override void GetDamage(float damage)
        {
            base.GetDamage(damage);
            Hp += 0.5f;
        }
    }

    interface IAnimals
    {
        void Move();
    }

    class Cat : IAnimals
    {
        public void Move()
        {
            Debug.Log("Move");
        }
    }

    internal class MyClass
    {
        private void NameMethod(IAnimals animal)
        {
            animal.Move();
        }

        private void NameMethod()
        {
            NameMethod(new Cat());
            NameMethod(null);
        }
    }
}

