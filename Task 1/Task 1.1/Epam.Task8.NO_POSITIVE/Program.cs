using System;

namespace Epam.Task8.NO_POSITIVE
{
    internal class Program
    {
        private static void Main()
        {
            float[,,] mas = new float[4, 5, 6];
            Random random = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        mas[i, j, k] = random.Next(-1000, 1000);
                        if (mas[i, j, k] > 0)
                        {
                            mas[i, j, k] = 0;
                        }
                    }
                }
            }

            Output(mas);
        }

        private static void Output(float[,,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        Console.WriteLine($"mas[{i}, {j}, {k}]={mas[i, j, k]}");
                    }
                }
            }
        }
    }
}
