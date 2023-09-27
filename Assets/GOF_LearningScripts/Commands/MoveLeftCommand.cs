using UnityEngine;

namespace GOF_LearningScripts.Commands
{
    public class MoveLeftCommand:ICommand
    {
        public void Execute(IGamePawn pawn)
        {
            Debug.Log("Move Left");
            pawn.MoveLeft();
        }
    }
}