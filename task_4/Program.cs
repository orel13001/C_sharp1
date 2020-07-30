using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lim = 3;
            int i = 0;
            do
            {
                Console.Write("Введите Логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите Пароль: ");
                string pas = Console.ReadLine();

                if (CheckAutorization(login, pas))
                {
                    Console.WriteLine("Добро пожаловать");
                    break;
                }
                else
                {
                    i++;
                    if (i < lim)
                    {
                        Console.WriteLine("Повторите попытку");
                    }

                }
            } while (i < lim);
            if (i >= lim)
            {
                Console.WriteLine("Вход запрещён!");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Проверка введённого логина и пароля
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="pas">пароль</param>
        /// <returns>Результат проверки</returns>
        private static bool CheckAutorization(string login, string pas)
        {
            if (login == "root" && pas == "GeekBrains")
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
