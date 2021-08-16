using System;

namespace Asteroids.Abstrac_Factory
{
    internal sealed class ActivatorExample
    {
        private void NameMethod()
        {
            var instance = Activator.CreateInstance<PlatformFactory>();
        }
    }
}
