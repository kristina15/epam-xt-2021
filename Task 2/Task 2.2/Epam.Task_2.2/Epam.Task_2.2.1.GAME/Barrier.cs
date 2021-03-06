using System;

namespace Epam.Task_2._2._1.GAME
{
    public abstract class Barrier : ObjectsOnField
    {
        protected Barrier(int _x, int _y) : base(_x, _y)
        {
        }

        public abstract bool Resist();
    }
}