using UnityEngine;

namespace GOF_LearningScripts.Commands
{
    public abstract class BaseMovementBehavior: MonoBehaviour,IGameActor
    {
        //需要保证子类也能被访问到
        protected ICommand moveForward;
        protected  ICommand moveLeft;
        protected  ICommand turnRight;
        protected ICommand emptyCommand;

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

        protected abstract ICommand HandleInput();


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
}