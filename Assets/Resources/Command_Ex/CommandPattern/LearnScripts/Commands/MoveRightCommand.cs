using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class MoveRightCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveRight();
        }
    }
}