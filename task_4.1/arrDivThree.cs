using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._1
{
    class arrDivThree
    {
        Random r = new Random();
        int[] arr = new int[20];

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public arrDivThree()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10000, 10001);
            }
        }

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public int CountDivThree()
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
    }
}
