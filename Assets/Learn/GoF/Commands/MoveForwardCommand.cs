using UnityEngine;

namespace Learn.GoF.Commands
{
    public class MoveForwardCommand:ICommand
    {
        public void Execute()
        {
            Debug.Log("Move Forward");
        }
    }
}