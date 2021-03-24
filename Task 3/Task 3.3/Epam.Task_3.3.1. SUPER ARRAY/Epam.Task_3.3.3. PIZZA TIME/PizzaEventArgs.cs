using System;

namespace Epam.Task_3._3._3.PIZZA_TIME
{
    public class PizzaEventArgs:EventArgs
    {
        public string Name { get; }
        public PizzaEventArgs(string _name)
        {
            Name = _name;
            Console.WriteLine($"{Name} your pizza is ready");
        }
    }
}
