namespace Resources.Command_Ex.CommandPattern.LearnScripts.Commands
{
    public class MoveLeftCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveLeft();
        }
    }
}