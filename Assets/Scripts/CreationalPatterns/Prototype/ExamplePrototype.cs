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
            
            PlayerData playerDataNew = playerData.DeepCopy();
            playerDataNew.Hp.CurrentHP = 200;
            
            Debug.Log(playerData);
            Debug.Log(playerDataNew);

            Instantiate(_prefab);
        }
    }
}
