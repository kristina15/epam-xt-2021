﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class Stone : Interface1
    {
        private int x;
        private int y;

        public Stone(Pole p, int x, int y)
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
                Console.WriteLine("Oh you hit a rock and it threw you 1 coordinate to the right!");
                h.X++;
                h.Check(p);
                return true;
            }

            return false;
        }
    }
}
