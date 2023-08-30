using UnityEngine;

namespace Learn.GoF.Commands
{
    public class TurnRightCommand:ICommand
    {
        public void Execute()
        {
            Debug.Log("Turn Right");
        }
    }
}