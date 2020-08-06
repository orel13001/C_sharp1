using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Random r = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10000, 10001);
            }

            arrStaticDivThree.Print(arr);
            Console.WriteLine(arrStaticDivThree.CountDivThree(arr));
            #endregion


            #region 2
            //Заполнение файла случайными значениями
            string t_file = "array.txt";
            StreamWriter sw = new StreamWriter(t_file);            
            int count = 20;
            int[] arr_write = new int[count];
            for (int i = 0; i < arr_write.Length; i++)
            {
                sw.WriteLine(r.Next(-10000, 10001));
            }
            sw.Close();

            //Считывание массива из файла и подсчёт пар значений
            int[] arr_read = arrStaticDivThree.GetArr(t_file, count);
            arrStaticDivThree.Print(arr_read);
            Console.WriteLine(arrStaticDivThree.CountDivThree(arr_read));
            #endregion

            Console.ReadKey();
        }
    }
}
