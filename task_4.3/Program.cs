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
            Console.WriteLine();
            arr1.Valfreq();

            arrClassDLL arr2 = arrClassDLL.Inverse(arr1);
            arr2.Print();




            Console.ReadKey();
        }
    }
}
