using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class AppleBonus : Interface1
    {
        private int x;
        private int y;

        public AppleBonus(Pole p, int x, int y)
        {
            if (x > p.Width || y > p.Heigth)
            {
                throw new ArgumentException();
            }
            else
            {
                this.x = x;
                this.y = y;
            }
        }

        public bool DoSomething(Hero h, Pole p)
        {
            if (x == h.X && y == h.Y)
            {
                Console.WriteLine("Congratulations you have collected a bonus and received one life as a gift!");
                p.CountOfBonus--;
                if (p.CountOfBonus == 0 && p.CountOfMonsters == 0)
                {
                    Console.WriteLine("Congratulations you have won!");
                    System.Environment.Exit(0);
                }

                return true;
            }

            return false;
        }
    }
}
