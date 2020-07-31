using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            int count = 0;

            for (long i = 1; i <= 100000000; i++)
            {
                if (CheckGood(i))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }

        /// <summary>
        /// Метод определения "хорошего числа"
        /// </summary>
        /// <param name="i">проверяемое число</param>
        /// <returns></returns>
        private static bool CheckGood(long i)
        {
            string s = Convert.ToString(i);
            int sum = 0;
            foreach (char c in s)
            {
                sum += Convert.ToInt32(c);
            }
            if (i % sum == 0)
            {
                return (true);
            }
            else { return (false); }
        }
    }
}
