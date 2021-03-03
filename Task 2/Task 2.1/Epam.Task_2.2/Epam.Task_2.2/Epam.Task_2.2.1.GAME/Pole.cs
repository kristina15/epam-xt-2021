using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class Pole
    {
        private int countOfBonus = 3;
        private int countOfMonsters = 2;
        private int width;
        private int heigth;

        public int Width
        {
            get
            {
                return width;
            }

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

        public int Heigth
        {
            get
            {
                return heigth;
            }

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

        public int CountOfMonsters { get => countOfMonsters; set => countOfMonsters = 2; }

        public int CountOfBonus { get => countOfBonus; set => countOfBonus = 3; }
    }
}
