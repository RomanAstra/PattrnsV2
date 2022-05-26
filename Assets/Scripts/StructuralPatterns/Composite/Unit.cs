namespace Asteroids.Composite
{
    public sealed class Unit : IAttack
    {
        public float Hp { get; private set; }
        public float Damage { get; }
        
        public void Attack(Unit unit)
        {
            unit.Hp -= Damage;
        }
    }
}
