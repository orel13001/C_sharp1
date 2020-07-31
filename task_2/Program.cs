using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            string a = Console.ReadLine();
            CountNumber(a);
            Console.ReadKey();
        }

        private static void CountNumber(string a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count++;
            }

            Console.WriteLine($"цифр в числе {a} - {count}");
        }
    }
}
