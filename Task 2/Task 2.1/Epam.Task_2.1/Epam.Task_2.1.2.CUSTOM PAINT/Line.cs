using System;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class Line:IFigure
    {
        private int x2;
        private int y2;

        public Line()
        {
            X1 = 0;
            X2 = 0;
            Y1 = 0;
            Y2 = 0;
        }

        public Line(int _x1, int _x2, int _y1, int _y2)
        {
            X1 = _x1;
            X2 = _x2;
            Y1 = _y1;
            Y2 = _y2;
        }

        public int X1 { get; set; }

        public int Y1 { get; set; }

        public int X2 
        { 
            get => x2; 
            set
            {
                if (value < X1)
                {
                    throw new ArgumentException("X2 cannot be more than X1");
                }

                x2 = value;
            }
        }

        public int Y2 
        {
            get => y2;
            set
            {
                if (value < Y1)
                {
                    throw new ArgumentException("Y2 cannot be more than Y1");
                }

                y2 = value;
            }
        }

        public int Length => (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

        public void Input()
        {
            Console.WriteLine("ВЫВОД: Введите параметры фигуры Линия");
            Console.Write("ВВОД: X1 = ");
            X1 = int.Parse(Console.ReadLine());
            X2 = X1;
            Console.Write("ВВОД: Y1 = ");
            Y1 = int.Parse(Console.ReadLine());
            Y2 = Y1;
            do
            {
                try
                {
                    Console.Write("ВВОД: X2 = ");
                    X2 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (X2 == X1);

            do
            {
                try
                {
                    Console.Write("ВВОД: Y2 = ");
                    Y2 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (Y2 == Y1);
            
        }

        public void Print()
        {
            Console.WriteLine($"Line with origin at point ({X1}, {Y1}) and with an end at the point ({X2}, {Y2}) and Length = {Length}");
        }
    }
}
