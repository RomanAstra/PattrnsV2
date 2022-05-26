using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asteroids.Abstrac_Factory
{
    internal sealed class ActivatorExample
    {
        private void NameMethod()
        {
            var instance = Activator.CreateInstance<PlatformFactory>();

             // Task.Factory.StartNew()

             // var task = new Task();
             // task.
              //ThreadPool
        }
    }
}
