using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._1
{
    class Complex_cl
    {
        private double re;
        private double im;

        /// <summary>
        /// Инициализация комплексного числа
        /// </summary>
        /// <param name="re">Действительная часть</param>
        /// <param name="im">Мнимая часть</param>
        public Complex_cl(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public Complex_cl()
        {
            this.re = 0;
            this.im = 0;
        }
        /// <summary>
        /// Сумма двух комплексных чисел
        /// </summary>
        /// <param name="z1">первое слогаемое</param>
        /// <param name="z2">второе слогаемое</param>
        /// <returns>Сумма</returns>
        public static Complex_cl operator + (Complex_cl z1, Complex_cl z2)
        {
            return new Complex_cl(z1.re + z2.re, z1.im + z2.im);
        }
        /// <summary>
        /// Разность двух комплексных чисел
        /// </summary>
        /// <param name="z1">Уменьшаемое</param>
        /// <param name="z2">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static Complex_cl operator - (Complex_cl z1, Complex_cl z2)
        {
            return new Complex_cl(z1.re - z2.re, z1.im - z2.im);
        }

        /// <summary>
        /// Произведение двух комплексных чисел
        /// </summary>
        /// <param name="z1">первый множитель</param>
        /// <param name="z2">второй множитель</param>
        /// <returns>Разность</returns>
        public static Complex_cl operator * (Complex_cl z1, Complex_cl z2)
        {
            return new Complex_cl((z1.re * z2.re - z1.im * z2.im), (z1.im * z2.re + z1.re * z2.im));
        }


        public override string ToString()
        {
            if (re == 0)
            {
                return Convert.ToString(this.im) + "i";
            }
            else if (this.im < 0)
            {
                return Convert.ToString(this.re) + " - " + Convert.ToString(-this.im) + "i";
            }
            else if (im == 0)
            {
                return Convert.ToString(this.re);
            }
            {
                return Convert.ToString(this.re) + " + " + Convert.ToString(this.im) + "i";
            }
        }
    }
}
