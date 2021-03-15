using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_2._1._2.CUSTOM_PAINT
{
    public class User
    {
        private List<IFigure> figures = new List<IFigure>();

        public string Name { get; set; }

        public User()
        {

        }
        public User(string _name)
        {
            Name = _name;
        }
        public void Output()
        {
            foreach (var item in figures)
            {
                item.Print();
            }
        }

        public void AddFigure(IFigure figure)
        {
            figures.Add(figure);
            figures[figures.Count - 1].Input();
        }

        public void ClearFigure()
        {
            figures.Clear();
        }
    }
}
