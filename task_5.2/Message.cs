using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task_5._2
{
    static class Message
    {
        /// <summary>
        /// Список слов не более заданной длинны
        /// </summary>
        /// <param name="s">Строка поиска</param>
        /// <param name="MaxCharCount">максимальная длинна слова</param>
        /// <returns>Список слов</returns>
        public static string Word_LenghtN(string s, int MaxCharCount)
        {
            string[] arrStr = s.Split(' ');
            StringBuilder outStr = new StringBuilder();
            Regex regex = new Regex(@"^[A-Za-zА-Яа-яЁё]{1," + MaxCharCount + "}$");
            string bufStr;
            for (int i = 0; i < arrStr.Length; i++)
            {
                bufStr = TrimWord(arrStr[i]);
                
                if (regex.IsMatch(bufStr.ToString()))
                {
                    if (outStr.Length == 0)
                        outStr.Append(bufStr.ToString());
                    else
                    {
                        outStr.Append(", ");
                        outStr.Append(bufStr);
                    }
                }
            }  
            
            return outStr.ToString();
        }

        /// <summary>
        /// Удаление слов, заканчивающихся на заданный символ
        /// </summary>
        /// <param name="s">Строка поиска</param>
        /// <param name="chr">Символ</param>
        /// <returns>Возращаемая строка</returns>
        public static string Delete_Word(string s, char chr)
        {
            string[] arrStr = s.Split(' ');
            StringBuilder outStr = new StringBuilder();
            Regex regex = new Regex(@"^[A-Za-zА-Яа-яЁё]{0,}" + chr.ToString() + "{1}$");
            string bufStr;
            for (int i = 0; i < arrStr.Length; i++)
            {

                bufStr = TrimWord(arrStr[i]);
                if (!regex.IsMatch(bufStr.ToString()))
                {
                    outStr.Append(arrStr[i]);
                    outStr.Append(" ");
                }
            }

            return outStr.ToString();
        }

        /// <summary>
        /// Удаление знаков пунктуации в начале и конце слова
        /// </summary>
        /// <param name="s">Исходное слово</param>
        /// <returns>Слово без знаков пунктуаации</returns>
        private static string TrimWord (string s)
        {
            StringBuilder bufStr = new StringBuilder(s);
            if (Char.IsPunctuation(bufStr[bufStr.Length - 1]))
            {
                bufStr.Remove(bufStr.Length - 1, 1);
            }
            if (Char.IsPunctuation(bufStr[0]))
            {
                bufStr.Remove(0, 1);
            }
            return bufStr.ToString();
        }

        /// <summary>
        /// Первое вхождение самого длинного слова в строке
        /// </summary>
        /// <param name="s">Строка поиска</param>
        /// <returns>Самое длинное слово</returns>
        public static string MaxLenghtWord(string s)
        {
            string[] arrStr = s.Split(' ');
            StringBuilder outStr = new StringBuilder();
            string bufStr;
            string maxWord = "";
            for (int i = 0; i < arrStr.Length; i++)
            {

                bufStr = TrimWord(arrStr[i]);
                if (bufStr.Length > maxWord.Length)
                {
                    maxWord = bufStr;
                }
            }

            return maxWord.ToString();
        }

        /// <summary>
        /// Список самых длинных слов в строке
        /// </summary>
        /// <param name="s">Строка поиска</param>
        /// <returns>Список слов</returns>
        public static string MaxLenghtWords(string s)
        {
            string maxWord = MaxLenghtWord(s);
            string[] arrStr = s.Split(' ');
            string bufStr;
            StringBuilder maxWords = new StringBuilder("");
            for (int i = 0; i < arrStr.Length; i++)
            {
                bufStr = TrimWord(arrStr[i]);
                if (bufStr.Length == maxWord.Length)
                {
                    if (maxWords.Length == 0)
                    {
                        maxWords.Append(bufStr.ToString());
                    }
                    else
                    {
                        maxWords.Append(", ");
                        maxWords.Append(bufStr);
                    }
                }
            }

            return maxWords.ToString();
        }






    }


}
