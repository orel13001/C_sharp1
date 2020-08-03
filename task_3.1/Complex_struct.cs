
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._1
{
    /// <summary>
    /// Структура комплексных чисел
    /// </summary>
    internal struct Complex_struct
    {
        private double re;
        private double im;

        /// <summary>
        /// Инициализация комплексного числа
        /// </summary>
        /// <param name="re">Действительная часть</param>
        /// <param name="im">Мнимая часть</param>
        public Complex_struct(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        /// <summary>
        /// Сумма двух комплексных чисел
        /// </summary>
        /// <param name="z1">первое слогаемое</param>
        /// <param name="z2">второе слогаемое</param>
        /// <returns>Сумма</returns>
        public static Complex_struct operator + (Complex_struct z1, Complex_struct z2)
        {
            return new Complex_struct(z1.re + z2.re, z1.im + z2.im);
        }
        /// <summary>
        /// Разность двух комплексных чисел
        /// </summary>
        /// <param name="z1">Уменьшаемое</param>
        /// <param name="z2">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static Complex_struct operator - (Complex_struct z1, Complex_struct z2)
        {
            return new Complex_struct(z1.re - z2.re, z1.im - z2.im);
        }


        public override string ToString()
        {
            if(re == 0)
            {
                return Convert.ToString(this.im) + "i";
            }
            else if (this.im < 0)
            {
                return Convert.ToString(this.re) + " - " + Convert.ToString(-this.im) + "i";
            }
            else if(im == 0 )
            {
                return Convert.ToString(this.re);
            }
            {
                return Convert.ToString(this.re) + " + " + Convert.ToString(this.im) + "i";
            }
        }
    }
}
