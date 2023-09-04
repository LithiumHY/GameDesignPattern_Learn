namespace Resources.Command_Ex.CommandPattern.LearnScripts.Commands
{
    public class MoveForwardCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveForward();
        }
    }
}