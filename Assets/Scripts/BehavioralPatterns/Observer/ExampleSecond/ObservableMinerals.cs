using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Observer.ExampleSecond
{
    public class ObservableMinerals : IObservable<Good>
    {
        private readonly List<IObserver<Good>> _observers = new 
            List<IObserver<Good>>();
        private Good _mineral;
        public Good Minerals
        {
            get
            {
                return _mineral;
            }
            set
            {
                _mineral = value;
                this.Notify(_mineral);
            }
        }

        private void Notify(Good mineral)
        {
            foreach (IObserver<Good> observer in _observers)
            {
                if (mineral.Name == null || mineral.Price < 0)
                {
                    observer.OnError(new Exception("Неправильные данные"));
                }
                else
                {
                    observer.OnNext(Minerals);
                }
            }
        }

        public void Stop()
        {
            foreach (IObserver<Good> observer in _observers)
            {
                if (_observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            }
            _observers.Clear();
        }


        public IDisposable Subscribe(IObserver<Good> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Good>> _observers;
            private IObserver<Good> _observer;

            public Unsubscriber(List<IObserver<Good>> observers, 
                IObserver<Good> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
    }
}
