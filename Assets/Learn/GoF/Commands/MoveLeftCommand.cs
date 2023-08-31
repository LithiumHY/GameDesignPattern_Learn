using UnityEngine;

namespace Learn.GoF.Commands
{
    public class MoveLeftCommand:ICommand
    {
        public void Execute(MovementBehavior actor)
        {
            Debug.Log("Move Left");
            actor.MoveLeft();
        }
    }
}