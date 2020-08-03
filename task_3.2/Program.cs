using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа. При вводе нуля производится расчёт");
            int num;
            int sum = 0;
            bool flag;
            string s;
            do
            {
                s = Console.ReadLine();
                flag = int.TryParse(s, out num);
                if (num % 2 != 0 && num > 0)
                {
                    sum += num;
                }
            } while (s != "0");
            Console.WriteLine("Сумма нечётных положительных чисел: " + sum);



            Console.ReadKey();
        }
    }
}
