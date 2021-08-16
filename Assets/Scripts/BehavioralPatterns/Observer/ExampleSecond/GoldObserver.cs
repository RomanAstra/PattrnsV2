using System;
using UnityEngine;

namespace BehavioralPatterns.Observer.ExampleSecond
{
    internal sealed class GoldObserver : IObserver<Good>
    {
        public void OnCompleted() => Debug.Log("Биржа закрыта.");
        public void OnError(Exception error)
        {
            Debug.Log($"Ошибка: {error.Message}");
        }
        public void OnNext(Good mineral)
        {
            if (mineral.Name == "Золото")
                Debug.Log($"Цена на золото {mineral.Price}");        
        }
    }
}
