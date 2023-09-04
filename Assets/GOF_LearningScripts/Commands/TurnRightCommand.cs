using UnityEngine;

namespace GOF_LearningScripts.Commands
{
    public class TurnRightCommand:ICommand
    {
        public void Execute(IGameActor actor)
        {
            Debug.Log("Turn Right");
            actor.TurnRight();
        }
    }
}