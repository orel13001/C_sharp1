using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        /// <summary>
        /// Расчёт суммы нечётных положительных чисел
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 0;
            int sum = 0;
            Console.WriteLine("Вводите целые числа. При вводе нуля производится расчёт");
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else if (a > 0 && a % 2 != 0)
                {
                    sum = sum + a;
                }
            } while (true);

            Console.WriteLine($"Сумма нечётных положительных чисел {sum}");
            Console.ReadKey();
        }
    }
}
