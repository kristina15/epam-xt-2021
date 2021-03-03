using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class Hero
    {
        public Hero()
        {
            X = 1;
            Y = 1;
            Life = 2;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Life { get; set; }

        public void CheckLife()
        {
            if (Life == 0)
            {
                Console.WriteLine("I'm sorry you lost!");
                System.Environment.Exit(0);
            }
        }

        public void Check(Pole p)
        {
            if (X <= 0 || Y <= 0 || X > p.Width || Y > p.Heigth)
            {
                Console.WriteLine("I'm sorry you lost 1 life and your new station (1, 1)");
                Life--;
                CheckLife();
                X = 1;
                Y = 1;
            }
        }

        public void Step(string s)
        {
            if (s == "Up")
            {
                Y++;
            }
            else if (s == "Down")
            {
                Y--;
            }
            else if (s == "Left")
            {
                X--;
            }
            else if (s == "Rigth")
            {
                X++;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
