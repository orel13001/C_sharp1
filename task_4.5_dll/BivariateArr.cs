using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._5_dll
{
    public class BivariateArr
    {
        static Random r = new Random();

        int[,] arr;

        /// <summary>
        /// Создание двумерного массива
        /// </summary>
        /// <param name="row">число строк</param>
        /// <param name="col">число столбцов</param>
        /// <param name="minVal">наименьшее возможное значение</param>
        /// <param name="maxVal">наибольшее возможное значение</param>
        public BivariateArr(int row, int col, int minVal, int maxVal)
        {
            arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = r.Next(minVal, maxVal);
                }
            }
        }

        public int[,] Arr
        {
            get { return arr; }
        }

        /// <summary>
        /// Сумма всех элементов массива
        /// </summary>
        /// <returns></returns>
        public int SumAll()
        {
            int sum_all = 0;
            foreach (int val in arr)
            {
                sum_all += val;
            }
            return sum_all;
        }

        /// <summary>
        /// Сумма всех элементов массива больше заданного
        /// </summary>
        /// <returns>значение, с которого начинается суммировани (значение в сумму не входит)</returns>
        public int SumAll(int start)
        {
            int sum_all = 0;
            foreach (int val in arr)
            {
                if (val > start)
                {
                    sum_all += val;
                }
            }
            return sum_all;
        }
        /// <summary>
        /// Максимальное значение в массиве
        /// </summary>
        public int MaxVal
        {
            get
            {
                int max_val = Int32.MinValue;
                foreach (int val in arr)
                {
                    if (val > max_val)
                    {
                        max_val = val;
                    }
                }
                return max_val;
            }
        }
        /// <summary>
        /// Минимальное значение в массиве
        /// </summary>
        public int MinVal
        {
            get
            {
                int min_val = Int32.MaxValue;
                foreach (int val in arr)
                {
                    if (val < min_val)
                    {
                        min_val = val;
                    }
                }
                return min_val;
            }
        }

        /// <summary>
        /// Нахождение позиции максимального элемента
        /// </summary>
        /// <param name="rowMax">строка</param>
        /// <param name="colMax">столбец</param>
        public void NumberMax(out int rowMax, out int colMax)
        {
            int max_val = 0;
            rowMax = -1;
            colMax = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max_val)
                    {
                        max_val = arr[i, j];
                        rowMax = i + 1;
                        colMax = j + 1;
                    }
                }
            }
        }

        /// <summary>
        /// печать массива
        /// </summary>
        public string Printing()
        {
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    str.Append($"{ arr[i, j],4}");
                }
                str.Append("\n");
            }
            return str.ToString();
        }
    }
}
