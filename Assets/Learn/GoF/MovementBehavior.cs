using System;
using Learn.GoF;
using Learn.GoF.Commands;
using UnityEngine;

public class MovementBehavior: MonoBehaviour
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
        command.Execute();
    }

    private ICommand HandleInput()
    {
        ICommand command = null;
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
}