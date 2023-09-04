using UnityEngine;
namespace GOF_LearningScripts.Commands
{
    public class AIMovementBehavior:BaseMovementBehavior
    {
        private ICommand[] commandList;
        private float stayTime = 2f;
        private ICommand lastCommand;
        protected override ICommand HandleInput()
        {
            //use methods like state-machine,decision tree,behavior tree,deep-learning to get the command
            //illustrate a logic like randomly choose a command
            
            
            if(stayTime>0)
            {
                stayTime -= Time.deltaTime; //Time.deltaTime is the time between two frames
                return lastCommand;
            }
            
            //the command changes every 2 seconds by using the codes below
            //连续执行一个命令，执行完成后，随机选择一个命令
            stayTime = Random.Range(0, 2);
            if (commandList == null)
            {
                commandList = new ICommand[]
                {
                    emptyCommand, moveForward, moveLeft, turnRight
                };
            }
            int index = Random.Range(0, commandList.Length);
            lastCommand = commandList[index];
            return lastCommand;
        }
    }
}