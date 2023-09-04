using UnityEngine;
namespace GOF_LearningScripts.Commands
{
    public class PlayerMovementBehavior : BaseMovementBehavior
    {
        protected override ICommand HandleInput()
        {
            ICommand command = emptyCommand;
            if (Input.GetKey(KeyCode.W))
            {
                command = moveForward;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                command = moveLeft;
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                command = turnRight;
            }
            return command;
        }
    }
}