using System;

namespace Epam.Task_2._2._1.GAME
{
    public  abstract class ObjectsOnField:Hero
    {
        protected int x;
        protected int y;

        protected ObjectsOnField(int _x, int _y)
        {
            if (_x > Width || _y > Heigth)
            {
                throw new ArgumentException();
            }
            else
            {
                x = _x;
                y = _y;
            }
        }

    }
}