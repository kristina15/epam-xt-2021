using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class WolfMonster : Monsters
    {
        public WolfMonster(int _x, int _y) : base(_x, _y)
        {
        }

        public override void Step()
        {
            if (y < Heigth)
            {
                y++;
            }
            else if (y == Heigth)
            {
                y = 1;
            }
        }
    }
}
