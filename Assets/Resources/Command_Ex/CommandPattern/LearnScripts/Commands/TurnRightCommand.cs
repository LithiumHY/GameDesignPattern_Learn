namespace Resources.Command_Ex.CommandPattern.LearnScripts.Commands
{
    public class TurnRightCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
            actor.TurnRight();
        }
    }
}