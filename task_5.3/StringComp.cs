using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._3
{
    class StringComp
    {
        public static bool StrRePlace(string strFirst, string strSecond)
        {
            Dictionary<char, int> dicFirst = new Dictionary<char, int>();
            Dictionary<char, int> dicSecond = new Dictionary<char, int>();

            char[] chrFirst = strFirst.ToCharArray();
            char[] chrSecond = strSecond.ToCharArray();

            Fill_Dictionary(ref dicFirst, chrFirst);
            Fill_Dictionary(ref dicSecond, chrSecond);

            if (strFirst.Length == strSecond.Length)
            {
                var dicKeys = dicFirst.Keys;
                foreach (var item in dicKeys)
                {
                    
                    if (!(dicFirst[item] == dicSecond[item]))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        private static void Fill_Dictionary(ref Dictionary<char, int> dic, char[] chr)
        {
            int elementCoun;
            for (int i = 0; i < chr.Length; i++)
            {
                elementCoun = 0;
                if (dic.ContainsKey(chr[i]))
                {
                    elementCoun = dic[chr[i]];
                    dic.Remove(chr[i]);
                    elementCoun++;
                    dic.Add(chr[i], elementCoun);
                }
                else
                {
                    elementCoun++;
                    dic.Add(chr[i], elementCoun);
                }
            }
        }
    }
}
