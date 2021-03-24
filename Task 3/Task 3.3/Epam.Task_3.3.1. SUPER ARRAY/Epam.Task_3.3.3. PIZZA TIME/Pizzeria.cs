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
        public event string MyEvent;

        public void AdditionalThread<T>(T[] arr, Func<T, T, int> compare)
        {
            ThreadStart ths = () => { Tasks4.Program.Quicksort(arr, 0, arr.Length - 1, compare); };
            Thread thread1 = new Thread(ths);
            thread1.Start();
            OnMyEvent("John");
        }

        protected virtual void OnMyEvent(string name)
        {
            MyEvent?.Invoke(this, new PizzaEventArgs(name));
        }
    }
}
