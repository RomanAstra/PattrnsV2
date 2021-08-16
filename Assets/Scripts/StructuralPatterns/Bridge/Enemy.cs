namespace Asteroids.Bridge
{
    internal sealed class Enemy
    {
        private IAttack _attack;
        private IMove _move;

        public Enemy(IAttack attack, IMove move)
        {
            _attack = attack;
            _move = move;
        }

        public void Attack()
        {
            _attack.Attack();
        }
        
        public void Move()
        {
            _move.Move();
        }
        
        public void SwitchMove(IMove move)
        {
            _move = move;
        }
    }
}
