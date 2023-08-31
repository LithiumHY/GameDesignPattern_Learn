using UnityEngine;

namespace Learn.GoF.Commands
{
    public class MoveLeftCommand:ICommand
    {
        public void Execute(IGameActor actor)
        {
            Debug.Log("Move Left");
            actor.MoveLeft();
        }
    }
}