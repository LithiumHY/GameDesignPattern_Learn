namespace Resources.Command_Ex.CommandPattern.LearnScripts.Commands
{
    public class TurnLeftCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.TurnLeft();
        }
    }
}