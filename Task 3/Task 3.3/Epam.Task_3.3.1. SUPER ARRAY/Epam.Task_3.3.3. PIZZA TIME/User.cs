using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task_3._3._3.PIZZA_TIME
{
    class User
    {
        Pizzeria pizzeria = new Pizzeria();
        public string Name { get; set; }

        public User(string _name)
        {
            Name = _name;
        }

        public void GetOrder(string nameOfPizza)
        {
            pizzeria.AdditionalThread(nameOfPizza, Name);
        }
    }
}
