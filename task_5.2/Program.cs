using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTest = @"На вход программы подается 366 строк, которые содержат информацию о среднесуточной температуре всех дней 2008 года. В каждой из строк среднесуточная сначала записана дата в виде dd.mm (на запись номера дня и номера месяца в числовом формате среднесуточный";

            Console.WriteLine(Message.Word_LenghtN(strTest, 3));

            Console.WriteLine(Message.Delete_Word(strTest, 'а'));

            Console.WriteLine(Message.MaxLenghtWord(strTest));

            Console.WriteLine(Message.MaxLenghtWords(strTest));


            Console.ReadKey();

        }
    }
}
