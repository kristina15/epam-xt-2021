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
            ThreadStart ths = () => { CookingPizza(nameOfPizza); };
            Thread thread1 = new Thread(ths);
            thread1.Start();
            OnMyEvent(nameOfPerson);
        }

        protected virtual void OnMyEvent(string name)
        {
            MyEvent?.Invoke(this, new PizzaEventArgs(name));
        }

        private void CookingPizza(string nameOfPizza)
        {
            switch(nameOfPizza)
            {
                case "Margarita":
                    Thread.Sleep(300);
                    break;
                case "B-B-Q":
                    Thread.Sleep(500);
                    break;
                case "Sicilian":
                    Thread.Sleep(500);
                    break;
                case "Hawaiian":
                    Thread.Sleep(1000);
                    break;
                case "Calzone":
                    Thread.Sleep(350);
                    break;
                case "Four cheeses":
                    Thread.Sleep(1000);
                    break;
                default:
                    break;
            }
        }
    }
}
