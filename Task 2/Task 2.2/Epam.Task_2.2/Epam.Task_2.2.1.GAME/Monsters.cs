using System;

namespace Epam.Task_2._2._1.GAME
{
    public abstract class Monsters:ObjectsOnField
    {
        public Monsters(int _x, int _y):base(_x, _y)
        {
        }

        public bool Attack()
        {
            Step();
            if (x == XOfHero && y == YOfHero)
            {
                Console.WriteLine("Ooh.... You lost your life, but managed to defeat this wild bear!");
                CountOfMonsters--;
                Life--;
                if (CountOfBonus == 0 && CountOfMonsters == 0)
                {
                    Console.WriteLine("Congratulations you have won!");
                    Environment.Exit(0);
                }

                return true;
            }

            return false;
        }

        public abstract void Step();
    }
}