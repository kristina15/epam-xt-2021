using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class Hero : Pole
    {
        private static int x = 1;
        private static int y = 1;
        public static int life = 1;

        public int XOfHero
        {
            get => x;
            set
            {
                if (x > Width || x < 0)
                {
                    Console.WriteLine("I'm sorry you lost!");
                    Environment.Exit(0);
                }

                x = value;
            }
        }

        public int YOfHero
        {
            get => y;
            set
            {
                if (y > Heigth || y < 0)
                {
                    Console.WriteLine("I'm sorry you lost!");
                    Environment.Exit(0);
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
                    Environment.Exit(0);
                }

                life = value;
            }
        }

        public void Step(string s)
        {
            switch (s)
            {
                case "Up":
                    YOfHero++;
                    break;
                case "Down":
                    YOfHero--;
                    break;
                case "Left":
                    XOfHero--;
                    break;
                case "Right":
                    XOfHero++;
                    break;
                default:
                    break;
            }
        }
    }
}
