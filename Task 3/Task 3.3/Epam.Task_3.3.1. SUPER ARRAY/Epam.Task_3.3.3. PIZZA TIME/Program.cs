using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_3._3._3.PIZZA_TIME
{
    class Program
    {
        static void Main()
        {
            User Anna = new User("Anna");
            Anna.GetOrder("Margarita");

            User Gleb = new User("Gleb");
            Gleb.GetOrder("Sicilian");

            User Kris = new User("Kristina");
            Kris.GetOrder("Calzone");

        }

    }
}
