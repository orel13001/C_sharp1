using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace task_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Type tp = dt.GetType();

            List<PropertyInfo> lst = tp.GetProperties().ToList<PropertyInfo>();
            foreach (var item in lst)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
            
        }
    }
}
