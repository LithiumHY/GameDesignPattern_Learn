using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class PlayerShooter : BaseShooter 
    {
        protected override ICommand HandleInput()
        {
            ICommand command = emptyCommand;
            if (Input.GetKey(KeyCode.W))
            {
                command = moveForward;
            }

            else if (Input.GetKey(KeyCode.S))
            {
                command = moveBack;
            }

            else if (Input.GetKey(KeyCode.A))
            {
                command = moveLeft;
            }

            else if (Input.GetKey(KeyCode.D))
            {
                command = moveRight;
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                command = turnLeft;
            }

            else if (Input.GetKey(KeyCode.E))
            {
                command = turnRight;
            }

            else if (Input.GetKey(KeyCode.J))
            {
                command = fire;
            }

            return command;       }
    }
}