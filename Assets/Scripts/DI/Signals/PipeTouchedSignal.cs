using UnityEngine;

namespace DI.Signals
{
    public class PipeTouchedSignal
    {
        public PipeTouchedSignal(Collision2D collision2D)
        {
            CollisionObj2D = collision2D;
        }

        public Collision2D CollisionObj2D
        {
            get;
            private set;
        }
    }    
}


