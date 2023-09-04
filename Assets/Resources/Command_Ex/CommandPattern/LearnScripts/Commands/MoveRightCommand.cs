namespace Resources.Command_Ex.CommandPattern.LearnScripts.Commands
{
    public class MoveRightCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveRight();
        }
    }
}