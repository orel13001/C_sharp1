using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var dict = MinimumFunc.ListFunc;
            var k = dict.Keys.ToArray();
            Console.WriteLine($"Выберите номер функции, для которой нужно найти минимум (1 - {dict.Count}):");
            for (int i = 0; i < dict.Count; i++)
            {
               Console.WriteLine($"{i+1,2}:   {k[i]}");
            }
            int funcNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите миниимальное значение аргумента: a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите максимальное значение аргумента: b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг приращения аргумента: h = ");
            double h = Convert.ToDouble(Console.ReadLine());

            MinimumFunc.SaveFunc(dict.Values.ToArray()[funcNumber], "func.bin", a, b, h);
            double min;
            var funcValues = MinimumFunc.LoadMin("func.bin", out min);
            for (int i = 0; i < funcValues.Count; i++)
            {
                Console.Write($"{funcValues[i]:0.000}; "); 
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальное значение функции {k[funcNumber]} в диапазоне от {a} до {b} с шагом {h}: {min:0.000}");


            Console.ReadKey();


        }


    }
}
