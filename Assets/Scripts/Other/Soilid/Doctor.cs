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
}
