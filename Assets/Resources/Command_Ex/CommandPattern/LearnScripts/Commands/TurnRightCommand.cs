using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class TurnRightCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.TurnRight();
        }
    }
}