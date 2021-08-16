using System;
using UnityEngine;

namespace BehavioralPatterns.Observer.ExampleSecond
{
    public class SilverObserver : IObserver<Good>
    {
        public void OnCompleted() =>  Debug.Log("Биржа закрыта.");
        public void OnError(Exception error)
        {
            Debug.Log($"Ошибка: {error.Message}");
        }
        public void OnNext(Good mineral)
        {
            if (mineral.Name == "Серебро" && mineral.Price > 17)
            {
                Debug.Log($"Цена на серебро {mineral.Price} превысила 17 долларов за унцию");
            }
        }
    }
}
