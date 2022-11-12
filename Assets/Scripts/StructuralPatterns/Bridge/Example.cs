using System;
using UnityEngine;

namespace Asteroids.Bridge
{
    internal sealed class Example : MonoBehaviour
    {
        private Enemy _enemy;
        private MoveSw _moveSw;
        private Infantry _infantry;


        private void Start()
        {
            _moveSw = new MoveSw();
            _infantry = new Infantry();
            _enemy = new Enemy(new MagicalAttack(), new MoveSw());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _enemy.Move();
            }
            if (Input.GetMouseButtonDown(0))
            {
                _enemy.Attack();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                _enemy.SwitchMove(_infantry);
            }
        }
    }
}
