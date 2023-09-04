using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class FireCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.Fire();
        }
    }
}