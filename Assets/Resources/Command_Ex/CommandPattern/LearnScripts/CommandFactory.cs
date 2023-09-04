using UnityEngine;

namespace CommandPattern.LearnScripts
{
    public static class CommandFactory
    {
        public static ICommand Create(KeyCode keyCode)
        {
            switch (keyCode)
            {
                case KeyCode.W: return new MoveForwardCommand();
                case KeyCode.S: return new MoveBackCommand();
                case KeyCode.A: return new MoveLeftCommand();
                case KeyCode.D: return new MoveRightCommand();
                case KeyCode.Q: return new TurnLeftCommand();
                case KeyCode.E: return new TurnRightCommand();
                case KeyCode.J: return new FireCommand();
                
                default:
                    return new EmptyCommand();
            }
        }
    }
}