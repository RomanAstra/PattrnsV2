namespace Other.Soilid
{
    internal abstract class Unit
    {
        public float Hp { get; protected set; } 
        public float Defense { get; } 
        
        public virtual void GetDamage(float damage)
        {
            if (Defense > damage)
            {
                return;
            }

            Hp -= damage - Defense;
        }
    }
}
