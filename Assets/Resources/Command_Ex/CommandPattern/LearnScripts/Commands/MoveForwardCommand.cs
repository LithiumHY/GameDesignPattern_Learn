using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class MoveForwardCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveForward();
        }
    }
}