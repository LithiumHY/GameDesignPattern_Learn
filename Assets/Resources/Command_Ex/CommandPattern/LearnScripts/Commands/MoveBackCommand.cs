namespace Resources.Command_Ex.CommandPattern.LearnScripts.Commands
{
    public class MoveBackCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.MoveBack();
        }
        
    }
}