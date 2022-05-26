using UnityEngine;

namespace Asteroids.Command.First
{
    internal sealed class DoNothing : ICommand
    {
        public bool Succeeded { get; private set; }
        public bool TryExecute()
        {
            Succeeded = true;
            return Succeeded;
        }

        public void Undo()
        {
        }
    }
}
