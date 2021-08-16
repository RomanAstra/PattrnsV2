using System;

namespace BehavioralPatterns.Observer.Asteroid
{
    internal interface IDeath
    {
        string Name { get; }
        event Action OnDeathChange;
    }
}
