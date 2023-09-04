using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class MoveBackCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveBack();
        }
        
    }
}