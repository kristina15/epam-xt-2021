using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class Pole
    {
        protected static int CountOfBonus = 3;
        protected static int CountOfMonsters = 2;
        private static int width=1;
        private static int heigth=1;

        public static int Width
        {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    width = value;
                }
            }
        }

        public static int Heigth
        {
            get => heigth;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    heigth = value;
                }
            }
        }
    }
}
