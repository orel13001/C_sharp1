using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_4._5_dll;

namespace task_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            BivariateArr arr = new BivariateArr(6, 8, 1, 100);
            Console.WriteLine(arr.Printing());
            Console.WriteLine($"Максимальное значение: {arr.MaxVal}");
            Console.WriteLine($"Минимальное значение: {arr.MinVal}");
            Console.WriteLine($"Сумма всех элементов массива: {arr.SumAll()}");
            int n = 20;
            Console.WriteLine($"Сумма элементов массива больше {n}: {arr.SumAll(n)}");
            int row, col;
            arr.NumberMax(out row, out col);
            Console.WriteLine($"Максимальное число в массиве {arr.Arr[row - 1, col - 1]}, строка {row}, столбец {col}");




            Console.ReadKey();
        }
    }
}
