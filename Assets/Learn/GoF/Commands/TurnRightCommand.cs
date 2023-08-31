using UnityEngine;

namespace Learn.GoF.Commands
{
    public class TurnRightCommand:ICommand
    {
        public void Execute(MovementBehavior actor)
        {
            Debug.Log("Turn Right");
            actor.TurnRight();
        }
    }
}