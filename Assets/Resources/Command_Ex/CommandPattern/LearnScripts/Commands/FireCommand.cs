namespace Resources.Command_Ex.CommandPattern.LearnScripts.Commands
{
    public class FireCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.Fire();
        }
    }
}