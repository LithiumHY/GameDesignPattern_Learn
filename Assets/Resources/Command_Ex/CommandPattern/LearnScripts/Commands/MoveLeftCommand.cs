using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class MoveLeftCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveLeft();
        }
    }
}