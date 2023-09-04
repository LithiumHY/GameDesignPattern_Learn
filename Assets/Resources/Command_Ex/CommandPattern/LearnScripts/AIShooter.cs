using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public class AIShooter : BaseShooter
    {
        private ICommand[] Commands;
        private float stayTime = 2f;
        private ICommand _lastCommand;
        protected override ICommand HandleInput()
        {
            if (stayTime > 0)
            {
                stayTime -= Time.deltaTime;
                return _lastCommand;
            }

            stayTime = Random.Range(0, 2);
            if (Commands == null) 
            {
                Commands = new ICommand[]
                {
                    emptyCommand, fire, moveBack, moveForward, moveLeft, moveRight, turnLeft,turnRight 
                };
            }
            int rand = Random.Range(0, 8);
            _lastCommand = Commands[rand];

            return _lastCommand;
        }
    }
}