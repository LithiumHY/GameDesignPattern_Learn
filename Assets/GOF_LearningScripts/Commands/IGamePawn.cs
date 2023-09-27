namespace GOF_LearningScripts.Commands
{
    //这个接口是为了让命令类能够调用Actor的方法，封装了所有的Actor的方法
    public interface IGamePawn
    {
        void MoveForward();
        void MoveLeft();
        void TurnRight();
    }
}