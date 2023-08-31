
using UnityEngine;

namespace Learn.GoF.Commands
{
    public static class CommandFactory
    {
        //动态创建不同类型的ICommand对象，并且返回
        public static ICommand Create(KeyCode keyCode)
        {
            switch (keyCode) 
            {
                //because of return, we don't need break
                case KeyCode.A:
                    return new MoveLeftCommand();
                case KeyCode.W:
                    return new MoveForwardCommand();
                case KeyCode.Q:
                    return new TurnRightCommand();
                
                //return error
                //but also could return null
                //default: return new EmptyCommand();
                default:
                    return new EmptyCommand();
                    //throw new System.IndexOutOfRangeException("error keycode + " + keyCode);
                //不需要在实际逻辑中判断是否为空
                
            }
        }
    }
}