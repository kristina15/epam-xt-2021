using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class WolfMonster : Interface1
    {
        private int x;
        private int y;

        public WolfMonster(Pole p, int x, int y)
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

        public void Step(Pole p)
        {
            if (y < p.Heigth)
            {
                y++;
            }
            else if (y == p.Heigth)
            {
                y = 1;
            }
        }

        public bool DoSomething(Hero h, Pole p)
        {
            Step(p);
            if (x == h.X && y == h.Y)
            {
                Console.WriteLine("Ooh.... You lost your life, but managed to defeat this wild wolf!");
                p.CountOfMonsters--;
                h.Life--;
                h.CheckLife();
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
