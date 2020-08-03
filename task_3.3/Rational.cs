using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._3
{
    class Rational
    {
        //поля класса: числитель и знаменатель РЧ
        int m, n;
        // открытые статические Константы класса доступные только для чтения
        public static readonly Rational zero, one;
        //закрытый конструктор класса. аргумент t введён для различия сигнатур конструктора.
        private Rational(int a, int b, string t)
        {
            m = a; n = b;
        }
        //статический конструктор класса, задающий значения констант
        static Rational()
        {
            zero = new Rational(0, 1, "privat");
            one = new Rational(1, 1, "privat");
        }

        /// <summary>
        /// Конструктор класса создаёт РЧ m/n равное a/b,
        /// но с взаимно не сократимыми числителем и знаменателем.
        /// если a = 0 , то создаётся РЧ 0/1
        /// </summary>
        /// <param name="a">числитель</param>
        /// <param name="b">заменатель</param>
        public Rational(int a, int b)
        {
            if (a == 0) { m = 0; n = 1; }
            else
            {
                
                int p = 1, m1 = a, n1 = b;
                //приведение знака (знак выводится перед числителем)
                if (b < 0) { b = -b; a = -a; }
                //приведение к несократимой дроби

                n1 = Math.Abs(n1); m1 = Math.Abs(m1);
                if (n1 > m1)
                { p = m1; m1 = n1; n1 = p; }
                do
                {
                    p = m1 % n1; m1 = n1; n1 = p;
                } while (n1 != 0);

                m = a / m1; n = b / m1;
                
            }
        }//Rational

        /// <summary>
        /// Возвращает числитель дроби
        /// </summary>
        public int GetM
        {
            get { return this.m; }
        }
        /// <summary>
        /// Возвращает знаменаель дроби
        /// </summary>
        public int GetN
        {
            get { return this.n; }
        }
        /// <summary>
        /// Возращает десятичную дробь
        /// </summary>
        public double GetDecimal
        {
            get { return (double)this.m / (double)this.n; }
        }

        /// <summary>
        /// печать рационального числа
        /// </summary>
        /// <param name="name">имя объекта рационального числа</param>
        public void PrintRational(string name)
        {
            Console.WriteLine("{0} = {1}/{2}", name, m, n);
        }//PrintRational

        /// <summary>
        /// метод сложения двух рациональных чисел. 
        /// прибавляет к текущему рациональному числу рациональное число переданное в качестве аргумента.
        /// </summary>
        /// <param name="a">аргумент</param>
        /// <returns>возвращает сумму двух рациональных чисел</returns>
        public Rational Plus(Rational a)
        {
            int u, v;
            u = m * a.n + n * a.m; v = n * a.n;// m,n - поля объекта, вызвавшего метод; a.m, a.n - поля объекта-аргумента
            return (new Rational(u, v));
        }//Plus
        //перегрузка оператора сложения
        public static Rational operator +(Rational r1, Rational r2)
        {
            return (r1.Plus(r2));
        }

        /// <summary>
        /// метод вычитания двух рациональных чисел. 
        /// вычитает от текущего рационального числа рациональное число переданное в качестве аргумента.
        /// </summary>
        /// <param name="a">аргумент</param>
        /// <returns>возвращает разность двух рациональных чисел</returns>
        public Rational Minus(Rational a)
        {
            int u, v;
            u = m * a.n - n * a.m; v = n * a.n;// m,n - поля объекта, вызвавшего метод; a.m, a.n - поля объекта-аргумента
            return (new Rational(u, v));
        }//Minus
        //перегрузка оператора вычитания
        public static Rational operator -(Rational r1, Rational r2)
        {
            return (r1.Minus(r2));
        }

        /// <summary>
        /// метод умнонжения двух рациональных чисел. 
        /// умножает текущее рациональное число на рациональное число переданное в качестве аргумента.
        /// </summary>
        /// <param name="a">аргумент</param>
        /// <returns>возвращает произведение двух рациональных чисел</returns>
        public Rational Mult(Rational a)
        {
            int u, v;
            u = m * a.m; v = n * a.n;// m,n - поля объекта, вызвавшего метод; a.m, a.n - поля объекта-аргумента
            return (new Rational(u, v));
        }//Mult
        //перегрузка оператора умножения
        public static Rational operator *(Rational r1, Rational r2)
        {
            return (r1.Mult(r2));
        }

        /// <summary>
        /// метод деления двух рациональных чисел. 
        /// делит текущее рациональное число на рациональное число переданное в качестве аргумента.
        /// </summary>
        /// <param name="a">аргумент</param>
        /// <returns>возвращает частное двух рациональных чисел</returns>
        public Rational Div(Rational a)
        {
            int u, v;
            u = m * a.n; v = n * a.m;// m,n - поля объекта, вызвавшего метод; a.m, a.n - поля объекта-аргумента
            return (new Rational(u, v));
        }//Div
        //перегрузка оператора деления
        public static Rational operator /(Rational r1, Rational r2)
        {
            return (r1.Div(r2));
        }

        //Перегрузка операций больше, меньше, неравно.
        public static bool operator ==(Rational r1, Rational r2)
        {
            return ((r1.m == r2.m) && (r1.n == r2.n));
        }
        public static bool operator !=(Rational r1, Rational r2)
        {
            return ((r1.m != r2.m) || (r1.n != r2.n));
        }
        public static bool operator <(Rational r1, Rational r2)
        {
            return (r1.m * r2.n < r1.n * r2.m);
        }
        public static bool operator >(Rational r1, Rational r2)
        {
            return (r1.m * r2.n > r1.n * r2.m);
        }
        public static bool operator <(Rational r1, double r2)
        {
            return (Convert.ToDouble(r1.m) / Convert.ToDouble(r1.n) < r2);
        }
        public static bool operator >(Rational r1, double r2)
        {
            return (Convert.ToDouble(r1.m) / Convert.ToDouble(r1.n) > r2);
        }
    }
}
