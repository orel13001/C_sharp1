using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_4._2
{
    static class arrStaticDivThree
    {
        /// <summary>
        /// Печать массива
        /// </summary>
        /// <param name="arr">Массив для печати</param>
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{ arr[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Расчёт пар значений, где одно из чисел делится на три
        /// </summary>
        /// <param name="arr">Массив для расчёта</param>
        /// <returns></returns>
        public static int CountDivThree(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int num1 = arr[i];
                int num2 = arr[i + 1];
                if ((num1 % 3 == 0 && num2 % 3 != 0) || (num1 % 3 != 0 && num2 % 3 == 0))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// чтение массива из файла
        /// </summary>
        /// <param name="Path">Путь к файлу</param>
        /// <param name="count">Число элементов массива</param>
        /// <returns></returns>
        public static int[] GetArr(string Path, int count)
        {
            int[] arr_read = new int[count];
            try
            {
                StreamReader sr = new StreamReader(Path);

                for (int i = 0; i < arr_read.Length; i++)
                {
                    arr_read[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
                return arr_read;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Файл " + Path + " не найден");
                return arr_read;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неверный формат данных");
                return arr_read;
            }
        }
    }
}
