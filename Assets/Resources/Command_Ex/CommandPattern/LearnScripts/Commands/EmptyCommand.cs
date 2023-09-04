namespace CommandPattern.LearnScripts
{
    public class EmptyCommand: ICommand
    {
        public void Execute(IGameActor actor)
        {
        }
    }
}