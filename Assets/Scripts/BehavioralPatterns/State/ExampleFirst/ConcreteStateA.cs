namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class ConcreteStateA : State
    {
        public override void Handle(Player player)
        {
            //----
            player.State = new ConcreteStateB();
        }
    }
}
