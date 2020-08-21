using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1
{
    static class Udvoitel
    {
        public static Random rnd = new Random();
        public static string Btn_Click(string btn, int val)
        {
            switch (btn)
            {
                case "btnAddOne":
                    pushStack(val);
                    return (val + 1).ToString();
                case "btnMultTwo":
                    pushStack(val);
                    return (val * 2).ToString();
                case "btnCancel":
                    stackVal.Clear();
                    return "0";
                default:
                    stackVal.Clear();
                    return "0";                    
            }
              
        }

        internal static string AddComandCount(int v)
        {
            return (++v).ToString();
        }
        internal static bool CompareValue (int val1, int val2)
        {
            return (val1 == val2); 
        }

        public static Stack<int> stackVal = new Stack<int>();
        
        static void pushStack(int val)
        {
            stackVal.Push(val);
        }
        public static string PopStack()
        {
            return stackVal.Pop().ToString();
        }
    }
}
