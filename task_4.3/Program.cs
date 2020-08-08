using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_4._3_dll;

namespace task_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            arrClassDLL arr1 = new arrClassDLL(20);
            arr1.Print();
            arr1.Valfreq();

            arrClassDLL arr2 = arrClassDLL.Inverse(arr1);
            arr2.Print();
            arrClassDLL arr3 = new arrClassDLL(10, 2, 2); // Если проект task_4.3_dll подгружен в решение,
                                                          //то при создании объекта intellisense подсказывает какой параметр конструктора что обозначает.
                                                          // Если проект task_4.3_dll выгружен, то отображается только сигнатура конструктора. Почему так происходит?
            arr3.Print();



            Console.ReadKey();
        }
    }
}
