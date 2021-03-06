using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class BearMonster : Monsters
    {
        public BearMonster(int _x, int _y) : base(_x, _y)
        {
        }

        public override void Step()
        {
            if (x < Width / 2 && y < Heigth / 2)
            {
                y++;
            }
            else if (x > Width / 2 && y > Heigth / 2)
            {
                y--;
            }
            else if (x > Width / 2 && y == Heigth / 2)
            {
                x--;
            }
            else
            {
                x++;
            }
        }
    }
}
