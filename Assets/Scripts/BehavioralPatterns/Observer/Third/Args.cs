using System;
using UnityEngine;

namespace BehavioralPatterns.Observer.Third
{
    [Serializable]
    public sealed class Args
    {
        public float ViewHp;
        public bool IsActive;
        public int CountEnemies;
        public Color ColorPlayer;
    }
}
