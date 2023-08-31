using UnityEngine;

namespace Learn.GoF
{
    public interface ICommand
    {
        void Execute(MovementBehavior actor);
    }
}
