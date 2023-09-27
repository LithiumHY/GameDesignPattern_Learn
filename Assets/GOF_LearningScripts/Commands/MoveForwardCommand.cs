using UnityEngine;

namespace GOF_LearningScripts.Commands
{
    public class MoveForwardCommand:ICommand
    {
        public void Execute(IGamePawn pawn)
        {
            Debug.Log("Move Forward");
            pawn.MoveForward();
        }
        
    }
}