using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._2
{
    interface IView
    {
        string InputVal { get; }
        string OutputVal { set; }
    }

    class Logic
    {
        IView view;

        public Logic(IView view)
        {
            this.view = view;
        }

        public void GiveValue()
        {
            view.OutputVal = $"Значение № {view.InputVal}";
        }
    }
}
