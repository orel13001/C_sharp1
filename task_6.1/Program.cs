using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6._1
{
    class Program
    {
        /// <summary>
        /// Делегат, принимает функции 2-х параметров типа double
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public delegate double SqrFunction(double a, double x);

        static void Main(string[] args)
        {
            Table(Func_AX2, 4, -10, 10);
            Console.WriteLine();
            Table(Func_ASINx, 3, -10, 10);


            Console.ReadKey();
        }
        /// <summary>
        /// Вычисление функции вида a*x^2
        /// </summary>
        /// <param name="a">Параметр а</param>
        /// <param name="x">Параметр х</param>
        /// <returns>Результат</returns>
        private static double Func_AX2(double a, double x)
        {
            return a * x * x;
        }
        /// <summary>
        /// Вычисление функции вида a*SIN(x)
        /// </summary>
        /// <param name="a">Параметр а</param>
        /// <param name="x">Параметр х</param>
        /// <returns>Результат</returns>
        private static double Func_ASINx(double a, double x)
        {
            return a * Math.Sin(x);
        }

        /// <summary>
        /// Построение таблици функции
        /// </summary>
        /// <param name="Func">Вычисляемая функция</param>
        /// <param name="a">Параметр а</param>
        /// <param name="xStart">начальное значение х</param>
        /// <param name="xEnd">конечное значение х</param>
        public static void Table (SqrFunction Func, double a, double xStart, double xEnd)
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine("-------X----------F(x)----------");
            while (xStart <= xEnd)
            {
                Console.WriteLine($"| {xStart,8:0.000} | {Func(a, xStart),8:0.000}");
                xStart += 1;
            }
        }
    }
}
