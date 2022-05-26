namespace Asteroids.Command.First
{
    public interface ICommand
    {
        bool Succeeded { get; }

        bool TryExecute();

        void Undo();
    }
}
