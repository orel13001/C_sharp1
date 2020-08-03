using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Complex_struct
            Console.WriteLine("Комплексные числа - Структура");
            Complex_struct z1 = new Complex_struct(9, -7);
            Complex_struct z2 = new Complex_struct(-9, 4);
            Console.WriteLine($"z1 = {z1.ToString()}");
            Console.WriteLine($"z2 = {z2.ToString()}");
            Complex_struct z3 = z1 + z2;
            Console.WriteLine($"z3 = {z3.ToString()}");
            Complex_struct z4 = z1 - z2;
            Console.WriteLine($"z4 = {z4.ToString()}");
            Console.WriteLine();
            #endregion

            #region Complex_cl
            Console.WriteLine("Комплексные числа - Класс");
            Console.Write("Введите действительную часть первого числа X.re=");
            double x_re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого числа X.im=");
            double x_im = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите действительную часть второго числа Y.re=");
            double y_re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть второго числа Y.im=");
            double y_im = Convert.ToDouble(Console.ReadLine());

            Complex_cl z_cl1 = new Complex_cl(x_re, x_im);
            Complex_cl z_cl2 = new Complex_cl(y_re, y_im);

            Console.Write("Введите символ операции, которую необходимо совершить ('+', '-', '*') ");
            char oper = Convert.ToChar(Console.ReadLine());
            Complex_cl z_cl3 = new Complex_cl();
            switch (oper)
            {
                case '+':{z_cl3 = z_cl1 + z_cl2;break;}
                case '-':{z_cl3 = z_cl1 - z_cl2;break;}
                case '*':{z_cl3 = z_cl1 * z_cl2;break;}
            }
            Console.WriteLine($"Результат: {z_cl3.ToString()}");

            #endregion


            Console.ReadKey();
        }
    }
}
