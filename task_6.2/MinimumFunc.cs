using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_6._2
{
    public delegate double delegDouble_X(double x);
    class MinimumFunc
    {
        private static double Func1(double x)
        {
            return x * x - 50 * x + 10;
        }
        private static double Func2(double x)
        {
            return x * x;
        }
        private static double Func3(double x)
        {
            return -2*x - 4*x;
        }
        private static double Func4(double x)
        {
            return 3*Math.Abs(x);
        }
        private static double Func5(double x)
        {
            return x * Math.PI;
        }

        /// <summary>
        /// Сохранение значений функции в файл
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <param name="a">начальное значение аргумента</param>
        /// <param name="b">конечное значение аргумента</param>
        /// <param name="h">шаг аргумента</param>
        public static void SaveFunc(delegDouble_X Func, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            double x = a;
            while (x <= b)
            {
                bw.Write(Func(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Загрузка значений функции из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="outMin">минимальное значение функции</param>
        /// <returns>Значения функции</returns>
        public static List<double> LoadMin(string fileName, out double outMin)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            List<double> lstValues = new List<double>();
            for (int i = 0; i < fs.Length/sizeof(double); i++)
            {
                lstValues.Add(br.ReadDouble());                
            }
            outMin = lstValues.Min();
            br.Close();
            fs.Close();
            return lstValues;
        }


        /// <summary>
        /// Получить перечень доступных функций
        /// </summary>
        public static Dictionary<string,delegDouble_X> ListFunc
        {
            get
            {
                Dictionary<string, delegDouble_X> dic = new Dictionary<string, delegDouble_X>();

                dic.Add("x * x - 50 * x + 10", Func1);
                dic.Add("x^2", Func2);
                dic.Add("-2*x - 4*x", Func3);
                dic.Add("3*|x|", Func4);
                dic.Add("x * PI", Func5);
                return dic;
                
            }
        }
        
            
    }
}
