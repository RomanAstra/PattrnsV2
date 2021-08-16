using System.Collections.Generic;

namespace BehavioralPatterns.Observer.ExampleSecond
{
    internal sealed class Example
    {
        private void Main()
        {
            var oc = new ObservableMinerals();
            var goldObserver = new GoldObserver();
            var silverObserver = new SilverObserver();
            IEnumerable<Good> minerals = new List<Good>
            {
                new Good(),
                new Good(),
            };
            using (oc.Subscribe(goldObserver))
            {
                using (oc.Subscribe(silverObserver))
                {
                    foreach (Good mineral in minerals)
                    {
                        oc.Minerals = mineral;
                    }
                    oc.Stop();
                }
            } 
        }
    }
}
