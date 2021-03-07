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
            Monsters monsters = new BearMonster(4, 4);
            Console.WriteLine("Сейчас ваш герой стоит на позиции (1, 1). Выберите движение дальше:\n1.Вверх\n2.Вниз\n3.Влево\n4.Вправо");
            string s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                switch(s)
                {
                    case "1":
                        hero.Step("Up");
                        goto default;
                    case "2":
                        hero.Step("Down");
                        goto default;
                    case "3":
                        hero.Step("Left");
                        goto default;
                    case "4":
                        hero.Step("Right");
                        goto default;
                    default:
                        bush.GetBonus();
                        monsters.Attack();
                        Console.WriteLine($"Положение героя ({hero.XOfHero}, {hero.YOfHero})");
                        Console.WriteLine("Выберите движение дальше:\n1.Вверх\n2.Вниз\n3.Влево\n4.Вправо");
                        s = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
