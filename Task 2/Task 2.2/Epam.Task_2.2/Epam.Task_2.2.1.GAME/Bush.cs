using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class Bush : Barrier
    {
        public Bush(int _x, int _y) : base(_x, _y)
        {
        }

        public override bool Resist()
        {
            if (x == XOfHero && y == YOfHero)
            {
                Console.WriteLine("Oh you hit a Bush and it threw you 2 coordinates down!");
                YOfHero -= 2;
                return true;
            }

            return false;
        }
    }
}
