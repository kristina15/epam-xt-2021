using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public abstract class RoundShape : IFigure
    {
        private int radius;

        public RoundShape()
        {
            X = 0;
            Y = 0;
            Radius = 0;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be less than 0");
                }

                radius = value;
            }
        }

        public virtual void Input()
        {
            Console.WriteLine("ВЫВОД: Введите координаты центра");
            Console.Write("ВВОД: x = ");
            X = int.Parse(Console.ReadLine());
            Console.Write("ВВОД: y = ");
            Y = int.Parse(Console.ReadLine());
            do
            {
                try
                {
                    Console.Write("ВВОД: Radius = ");
                    Radius = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (Radius == 0);
        }

        public virtual void Print() 
        {
            Console.Write($" centered at a point ({X}, {Y}), Radius = {Radius}");
        }
    }
}
