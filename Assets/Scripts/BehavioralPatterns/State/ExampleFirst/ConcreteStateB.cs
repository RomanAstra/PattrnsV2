namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class ConcreteStateB : State
    {
        public override void Handle(Player player)
        {
            if (player.Hp > 0)
            {
                
            }
                
            player.State = new ConcreteStateA();
        }
    }
}
