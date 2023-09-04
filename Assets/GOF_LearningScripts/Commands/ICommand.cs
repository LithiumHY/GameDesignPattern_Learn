namespace GOF_LearningScripts.Commands
{
    public interface ICommand
    {
        void Execute(IGameActor actor);
    }
}
