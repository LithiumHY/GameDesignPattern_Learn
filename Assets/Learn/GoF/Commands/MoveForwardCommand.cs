using UnityEngine;

namespace Learn.GoF.Commands
{
    public class MoveForwardCommand:ICommand
    {
        //没有信息，添加一个对behavior的引用
        public MovementBehavior Behavior;
        public void Execute(IGameActor actor)
        {
            Debug.Log("Move Forward");
            actor.MoveForward();
        }
        
    }
}