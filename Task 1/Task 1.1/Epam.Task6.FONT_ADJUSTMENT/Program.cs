using System;
using System.Text;

namespace Epam.Task6.FONT_ADJUSTMENT
{
    internal class Program
    {
        private static void Main()
        {
            string b = "Введите:\n\t1: bold\n\t2: italic\n\t3: underline";
            string s = "Параметры надписи: ";
            StringBuilder a = new StringBuilder("None ");
            Console.WriteLine($"{s}{a}\n{b}");
            GetFontSet(b, s, a);
        }

        private static void GetFontSet(string b, string s, StringBuilder a)
        {
            bool flag = true;
            do
            {
                string str = Console.ReadLine();
                flag = int.TryParse(str, out int i);
                switch (i)
                {
                    case 1:
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j] == 'N')
                            {
                                a.Remove(j, 5);
                                a.Append("Bold ");
                                break;
                            }

                            if (a[j] == 'B')
                            {
                                a.Remove(j, 5);
                                if (a.Length == 0)
                                {
                                    a.Append("None ");
                                }

                                break;
                            }

                            if (j == a.Length - 1)
                            {
                                a.Append("Bold ");
                                break;
                            }
                        }

                        Console.WriteLine($"{s}{a}\n{b}");
                        break;

                    case 2:
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j] == 'N')
                            {
                                a.Remove(j, 5);
                                a.Append("Italic ");
                                break;
                            }

                            if (a[j] == 'I')
                            {
                                a.Remove(j, 7);
                                if (a.Length == 0)
                                {
                                    a.Append("None ");
                                }

                                break;
                            }

                            if (j == a.Length - 1)
                            {
                                a.Append("Italic ");
                                break;
                            }
                        }

                        Console.WriteLine($"{s}{a}\n{b}");
                        break;

                    case 3:
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j] == 'N')
                            {
                                a.Remove(j, 5);
                                a.Append("Underline ");
                                break;
                            }

                            if (a[j] == 'U')
                            {
                                a.Remove(j, 10);
                                if (a.Length == 0)
                                {
                                    a.Append("None ");
                                }

                                break;
                            }

                            if (j == a.Length - 1)
                            {
                                a.Append("Underline ");
                                break;
                            }
                        }

                        Console.WriteLine($"{s}{a}\n{b}");
                        break;
                }
            } while (flag);
        }
    }
}
