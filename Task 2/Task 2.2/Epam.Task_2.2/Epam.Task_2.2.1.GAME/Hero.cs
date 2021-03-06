using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class Hero:Pole
    {
        private static int x;
        private static int y;
        public static int life;
        public Hero()
        {
            XOfHero = 1;
            YOfHero = 1;
            Life = 2;
        }

        public int XOfHero
        {
            get => x;
            set
            {
                if (x > Width || x < 0)
                {
                    Console.WriteLine("I'm sorry you lost!");
                    System.Environment.Exit(0);
                }

                x = value;
            }
        }

        public int YOfHero{
            get => y;
            set
            {
                if (y > Heigth || y < 0)
                {
                    Console.WriteLine("I'm sorry you lost!");
                    System.Environment.Exit(0);
                }

                y = value;
            }
        }

        public int Life
        {
            get => life;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("I'm sorry you lost!");
                    System.Environment.Exit(0);
                }

                life = value;
            }
        }

        public void Step(string s)
        {
            if (s == "Up")
            {
                YOfHero++;
            }
            else if (s == "Down")
            {
                YOfHero--;
            }
            else if (s == "Left")
            {
                XOfHero--;
            }
            else if (s == "Rigth")
            {
                XOfHero++;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
