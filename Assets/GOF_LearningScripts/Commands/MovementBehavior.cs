using System;
using Learn.GoF;
using Learn.GoF.Commands;
using UnityEngine;

public class MovementBehavior: MonoBehaviour,IGameActor
{
    private ICommand moveForward;
    private ICommand moveLeft;
    private ICommand turnRight;
    private ICommand emptyCommand;

    private void Start()
    //接口初始化
    //根据一个基类的不同类型
    {
        moveForward = CommandFactory.Create(KeyCode.W);
        moveLeft = CommandFactory.Create(KeyCode.A);
        turnRight = CommandFactory.Create(KeyCode.Q);
        emptyCommand = CommandFactory.Create(default);
    }

    private void Update()
    {
        #region OldMethod
        // public void MoveForward()
        // {
        //     Debug.Log("MoveForward");
        // }
        //
        // public void MoveLeft()
        // {
        //     Debug.Log("MoveLeft");
        // }
        // public void TurnRight()
        // {
        //     Debug.Log("TurnRight");
        // }
        #endregion
        //var command = HandleInput();
        var command = HandleInput();
        command.Execute(this);
    }

    private ICommand HandleInput()
    {
        ICommand command = emptyCommand;
        if (Input.GetKey(KeyCode.W))
        {
            command = moveForward;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            command = moveLeft;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            command = turnRight;
        }
        return command;
    }

    
    //虽然方法是一样的，但是抽象化了，行为和行为的执行者耦合被删除了
    //只关心shooter behavior的对应行为，并不关心他的其他属性

    public void MoveForward()
    {
        
    }

    public void MoveLeft()
    {
        
    }

    public void TurnRight()
    {
        
    }
}