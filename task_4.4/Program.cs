using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"log_pass.txt";
            Account acc = new Account(path);
            Console.WriteLine(acc.Login);

            
            for (int i = 0; i < acc.Length; i++)
            {
                Console.WriteLine(acc[i]);
            }



            Console.ReadKey();
        }
    }
}
