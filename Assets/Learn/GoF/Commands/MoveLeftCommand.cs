using UnityEngine;

namespace Learn.GoF.Commands
{
    public class MoveLeftCommand:ICommand
    {
        public void Execute()
        {
            Debug.Log("Move Left");
        }
    }
}