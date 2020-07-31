using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            FindMin(a, b, c);

            Console.ReadKey();
        }
        /// <summary>
        /// Нахождение минимума из трёх чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        private static void FindMin(int a, int b, int c)
        {
            int min;

            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                min = (b < c) ? b : c;
            }
            Console.WriteLine($"Минимальное число {min}");
        }
    }
}
