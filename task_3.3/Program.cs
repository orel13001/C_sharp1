using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(6,10);
            r1.PrintRational("r1");
            Rational r2 = new Rational(3, 0);
            r2.PrintRational("r2");

            Rational result = r1 + r2;
            result.PrintRational("Результат сложения r1 + r2: result");
            result = r1 - r2;
            result.PrintRational("Результат разности r1 - r2: result");
            result = r1 * r2;
            result.PrintRational("Результат умножения r1 * r2: result");
            result = r1 / r2;
            result.PrintRational("Результат деления r1 / r2: result");

            Console.WriteLine($"Числитель result равен: {result.GetM}");
            Console.WriteLine($"Знаменатель result равен: {result.GetN}");
            Console.WriteLine($"Десятичное представление result: {result.GetDecimal}");


            Console.ReadKey();
        } 
    }
}
