using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double maxNormIMB = 25;
            const double minNormIMB = 18.5;
            Console.WriteLine("Введите массу в кг:");
            double mas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в м:");
            double height = Convert.ToDouble(Console.ReadLine());

            double IMB = GetIndexMassBody(mas, height);
            string message;
            if (IMB < minNormIMB)
            {
                message = "Вам нужно набрать вес";
            }
            else if (IMB > minNormIMB)
            {
                message = "Вам нужно сбросить вес";
            }
            else
            {
                message = "Ваш вес в норме";
            }

            Console.WriteLine($"ИМТ = {IMB}\n{message}");
            Console.ReadKey();
        }

        
        /// <summary>
        /// Расчёт индекса массы тела
        /// </summary>
        /// <param name="mas">масса</param>
        /// <param name="height">рост</param>
        /// <returns>ИМТ</returns>
        private static double GetIndexMassBody(double mas, double height)
        {
            return (mas / (height * height));
        }
    }
}
