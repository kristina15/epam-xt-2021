using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    internal class Program
    {
        public static List<Figure> figures=new List<Figure>();

        private static void Main()
        {
            int k = 0;
            do
            {
                Console.Write("ВЫВОД: Выберите действие\n1. Добавить фигуру\n2. Вывести фигуры\n3. Очистить холст\n4. Выход\nВВОД: ");
                k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine("Выберите тип фигуры\n\t1. Линия\n\t2. Круг\n\t3. Прямоугольник\n\t4. Квадрат\n\t5. Кольцо\n\t6. Окружность");
                        ChooseFigure();
                        break;
                    case 2:
                        OutputAllFigures();
                        break;
                    case 3:
                        figures.Clear();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (k != 0 && k != 4);
        }

        private static void ChooseFigure()
        {
            int number=int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    figures.Add(new Line());
                    figures[figures.Count - 1].Input();
                    break;
                case 2:
                    figures.Add(new Circle());
                    figures[figures.Count - 1].Input();
                    break;
                case 3:
                    figures.Add(new Rectangle());
                    figures[figures.Count - 1].Input();
                    break;
                case 4:
                    figures.Add(new Square());
                    figures[figures.Count - 1].Input();
                    break;
                case 5:
                    figures.Add(new Ring());
                    figures[figures.Count - 1].Input();
                    break;
                case 6:
                    figures.Add(new Round());
                    figures[figures.Count - 1].Input();
                    break;
                default:
                    break;
            }

        }

        public static void OutputAllFigures()
        {
            foreach (var item in figures)
            {
                item.Print();
            }
        }
    }
}
