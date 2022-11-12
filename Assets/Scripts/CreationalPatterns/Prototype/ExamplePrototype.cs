using UnityEngine;

namespace Asteroids.Prototype
{
    internal sealed class ExamplePrototype : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        private void Start()
        {
            PlayerData playerData = new PlayerData
            {
                Hp = new Hp
                {
                    CurrentHP = 100,
                    MaxHP = 100
                },
                Speed = 100
            };
            
            PlayerData playerDataNew = (PlayerData)playerData.Clone();
            playerDataNew.Hp.CurrentHP = 200;

            PlayerData playerDataNewNew = playerData.DeepCopy();
            playerDataNewNew.Hp.CurrentHP = 42;

            PlayerData playerDataNewNewNew = playerData;
            playerDataNewNewNew.Hp.CurrentHP = 43;
            
            Debug.Log(playerData);
            Debug.Log(playerDataNew);
            Debug.Log(playerDataNewNew);
            Debug.Log(playerDataNewNewNew);

            // Instantiate(_prefab);
            var a = new A
            {
                T = 42
            };
            NameMethod(a); 
            Debug.Log(a.T);
        }

        internal struct A
        {
            public int T;
        }

        private void NameMethod(A a)
        {
            a.T = 24;
        }
    }
}
