namespace Resources.Command_Ex.CommandPattern.LearnScripts
{
    public interface IGameActor
    {
        void Fire();
        void MoveBack();
        void MoveForward();
        void MoveLeft();
        void MoveRight();
        void TurnLeft();
        void TurnRight();
    }
}