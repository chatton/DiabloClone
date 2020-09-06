using Core;
using UnityEngine;

namespace Movement
{
    public class MoveAction : IAction
    {
        private readonly Mover _mover;
        private readonly Vector3 _destination;

        public MoveAction(Mover mover, Vector3 destination)
        {
            _mover = mover;
            _destination = destination;
        }

        public void Execute()
        {
            _mover.MoveTo(_destination);
        }

        public void Cancel()
        {
            _mover.Stop();
        }
    }
}