using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class TurnLeftCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.TurnLeft();
        }
    }
}