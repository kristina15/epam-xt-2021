using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task_3._3._3.PIZZA_TIME
{
    class Pizzeria
    {
        public event EventHandler<PizzaEventArgs> MyEvent;

        public void AdditionalThread(string nameOfPizza, string nameOfPerson)
        {
            ThreadStart ths = () => { CookingPizza(nameOfPizza, nameOfPerson); };
            Thread thread1 = new Thread(ths);
            thread1.Start();
            OnMyEvent();
        }

        protected void OnMyEvent()
        {
            MyEvent?.Invoke(this, new PizzaEventArgs());
        }

        private void CookingPizza(string nameOfPizza, string nameOfPerson)
        {
            switch(nameOfPizza)
            {
                case "Margarita":
                    Thread.Sleep(3000);
                    break;
                case "B-B-Q":
                    Thread.Sleep(5000);
                    break;
                case "Sicilian":
                    Thread.Sleep(5500);
                    break;
                case "Hawaiian":
                    Thread.Sleep(1000);
                    break;
                case "Calzone":
                    Thread.Sleep(350);
                    break;
                case "Four cheeses":
                    Thread.Sleep(10000);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{nameOfPerson} your pizza is ready");
        }
    }
}
