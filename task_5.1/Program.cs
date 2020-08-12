using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CheckLogin
            //Console.Write("Введите логин: ");
            //string login = Console.ReadLine();
            //if (login.Length >= 2 && login.Length <= 10)
            //{
            //    char[] chrLogin = login.ToCharArray();
            //    bool preCheck = true;
            //    foreach (var chr in chrLogin)
            //    {
            //        if (!((Char.IsDigit(chr)) || ((chr >= 'a') && (chr <= 'z')) || ((chr >= 'A') && (chr <= 'Z'))))
            //        {
            //            Console.WriteLine("Неверный логин");
            //            preCheck = false;
            //            break;
            //        }
            //    }
            //    if (preCheck)
            //    {
            //        if (Char.IsLetter(chrLogin[0]))
            //        {
            //            Console.WriteLine("Логин верный");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Неверный логин");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Неверный логин");
            //}
            #endregion


            #region CheckRegExp

            string pattern = @"^[A-Za-z]{1}[A-Za-z0-9]{1,9}$";
            Regex reg = new Regex(pattern);
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            if (reg.IsMatch(login))
            {
                Console.WriteLine("Логин верный");
            }
            else
            {
                Console.WriteLine("Неверный логин");
            }

            #endregion




            Console.ReadKey();
        }
    }
    
}
