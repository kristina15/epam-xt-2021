using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._2._1.GAME
{
    class Program
    {
        static void Main()
        {
            Pole.Width = 5;
            Pole.Heigth = 5;
            Hero hero = new Hero();
            Bonuses bush = new AppleBonus(1, 2);
            hero.Step("Up");
            bush.GetBonus();
            Console.WriteLine(hero.Life);

            Hero hero2 = new Hero();
            Console.WriteLine(hero2.Life);
            Bonuses bonuse = new CherryBonus(2, 1);
            hero2.Step("Right");
            bonuse.GetBonus();
            Console.WriteLine(hero2.Life);
        }
    }
}
