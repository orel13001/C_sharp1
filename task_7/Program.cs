using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            recurs(a,b);
            Console.WriteLine(Sumrecurs(a, b));
            Console.ReadKey();
        }

        /// <summary>
        /// Рекурсивный вывод чисел от а до b
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        private static void recurs(int a, int b)
        {
            if (a <= b)
            {
                Console.Write(a + " ");
                recurs(a + 1, b);
            }
            else Console.WriteLine();
        }

        /// <summary>
        /// Сумма чисел от а до b
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <returns>Сумма чисел</returns>
        private static int Sumrecurs(int a, int b)
        {
            int sum = 0;
            if (a <= b)
            {
                sum = a + Sumrecurs(a + 1, b);
                return (sum);
            }
            else
            {
                return (sum);
            }

        }
    }
}
