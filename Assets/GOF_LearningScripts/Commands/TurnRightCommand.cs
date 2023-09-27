using UnityEngine;

namespace GOF_LearningScripts.Commands
{
    public class TurnRightCommand:ICommand
    {
        public void Execute(IGamePawn pawn)
        {
            Debug.Log("Turn Right");
            pawn.TurnRight();
        }
    }
}