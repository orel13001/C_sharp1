using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_4._3_dll
{
    public class arrClassDLL
    {
        /// <summary>
        /// Поля класса
        /// </summary>
        private int[] a;
        Random rnd = new Random();

        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>
        /// <param name="n"></param>
        public arrClassDLL(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 10);
            }
        }

        /// <summary>
        /// Конструктор считывания массива из файла
        /// </summary>
        /// <param name="fileName"></param>
        public arrClassDLL(string fileName)
        {
            try
            {
                if (File.Exists(fileName)) //если файл существует
                {
                    string[] ss = File.ReadAllLines(fileName); //считываем все строки и закрываем файл
                    a = new int[ss.Length];
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = int.Parse(ss[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Файл отстствует");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Невозможно обработать данные из файла. {ex.GetType()}. {ex.Message}");
            }
        }

        /// <summary>
        /// конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <param name="start">начальное значение </param>
        /// <param name="step">шаг</param>
        public arrClassDLL(int n, int start, int step)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    a[i] = start;
                }
                else
                {
                    a[i] = start += step;
                }
            }
        }

        /// <summary>
        /// Закрытый конструктор, создающий инвертированный массив
        /// </summary>
        /// <param name="arr"></param>
        private arrClassDLL(arrClassDLL arr)
        {
            a = new int[arr.a.Length];
            for (int i = 0; i < arr.a.Length; i++)
            {
                a[i] = -arr[i];
            }
        }

        /// <summary>
        /// Статический метод, создающий инвертированный массив
        /// </summary>
        /// <param name="arr"></param>
        public static arrClassDLL Inverse(arrClassDLL arr)
        {
            arrClassDLL newArr = new arrClassDLL(arr);
            return newArr;
        }

        /// <summary>
        /// Умножает все элементы массива на заданный множитель
        /// </summary>
        /// <param name="n">Множитель</param>
        public void Multi(int n)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] *= n;
            }
        }

        /// <summary>
        /// Возвращает максимальный элемент массива
        /// </summary>
        public int Max
        {
            get { return a.Max(); }
        }

        /// <summary>
        /// свойство-индексатор
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }


        public void Print()
        {
            foreach (int s in a)
            {
                Console.Write("{0,4}", s);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }

        /// <summary>
        /// Поодсчёт повторяющихся элементов массива
        /// </summary>
        public void Valfreq()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>(a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                int buf = 0;
                if (dic.ContainsKey(a[i]))
                {
                    dic.TryGetValue(a[i], out buf);
                    dic.Remove(a[i]);
                    dic.Add(a[i], ++buf);
                }
                else
                {
                    dic.Add(a[i], ++buf);
                }
            }
            int[] arrKeys = dic.Keys.ToArray();
            int[] arrVal = dic.Values.ToArray();

            for (int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine($"Значение {arrKeys[i]} повторяется {arrVal[i]} раз");
            }
        }
    }
}
