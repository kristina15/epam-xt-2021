﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    public class PunapppleBonus : Bonuses
    {
        public PunapppleBonus(int _x, int _y) : base(_x, _y)
        {
        }

        public override bool GetBonus()
        {
            if (x == XOfHero && y == YOfHero)
            {
                Console.WriteLine("Congratulations you have collected a bonus and one monster was killed as a gift!");
                CountOfBonus--;
                CountOfMonsters--;
                if (CountOfBonus == 0 && CountOfMonsters == 0)
                {
                    Console.WriteLine("Congratulations you have won!");
                    Environment.Exit(0);
                }

                return true;
            }

            return false;
        }
    }
}
