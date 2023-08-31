using Learn.GoF.Commands;
using UnityEngine;

namespace Learn.GoF
{
    public interface ICommand
    {
        void Execute(IGameActor actor);
    }
}
