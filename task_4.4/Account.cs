using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_4._4
{
    /// <summary>
    /// Структура описывает массив аккаунтов (логин и пароль)
    /// </summary>
    struct Account
    {
        string[] login;
        string[] pass;

        /// <summary>
        /// Считывание логина и пароля из файла
        /// </summary>
        /// <param name="fileName">полное имя файула</param>
        public Account(string fileName)
        {
            login = new string[0];
            pass = new string[0];
            try
            {
                StreamReader sr = new StreamReader(fileName);
                int i = 0;
                while (!sr.EndOfStream)
                {
                    i++;
                    Array.Resize(ref login, i);
                    Array.Resize(ref pass, i);
                    string singIn = sr.ReadLine();
                    login[i-1] = singIn.Split(' ')[0];
                    pass[i-1] = singIn.Split(' ')[1];
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Файл не найден");
            }
        }

        /// <summary>
        /// Показать пару логин/пароль
        /// </summary>
        /// <param name="i">индекс пары</param>
        /// <returns></returns>
        public string this[int i]
        {
            get { return $"{login[i]}  {pass[i]}/n"; }
        }


        /// <summary>
        /// Показать список логинов
        /// </summary>
        public string Login
        {
            get 
            {
                StringBuilder str = new StringBuilder("");
                for (int i = 0; i < login.Length; i++)
                {
                    str.Append($"{i} {login[i]}\n");
                }
                return str.ToString(); 
            }
        }

        /// <summary>
        /// Количество аккаунтов
        /// </summary>
        public int Length
        {
            get { return login.Length; }
        }
    }
}
