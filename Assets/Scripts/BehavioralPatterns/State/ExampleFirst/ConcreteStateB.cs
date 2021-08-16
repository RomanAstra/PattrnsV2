namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            if (context.Hp > 0)
            {
                
            }
                
            context.State = new ConcreteStateA();
        }
    }
}
