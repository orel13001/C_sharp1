using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_7._2
{
    static class Answer
    {
        static int guessVal;
        static int uAnsw;


        public static int SetGuessVal
        {
            set { guessVal = value; }
        }    
        
        
        internal static void UserAnswer()
        {            
            new UserAsk().Show();
        }


        internal static void Check(int uAnswer)
        {
            uAnsw = uAnswer;
            if (uAnswer == guessVal)
            {
                MessageBox.Show($"Вы угадали!!!");
            }
            else if(uAnswer < guessVal)
            {
                MessageBox.Show($"Загаданное число больше!");
                UserAnswer();
            }
            else if (uAnswer > guessVal)
            {
                MessageBox.Show($"Загаданное число меньше!");
                UserAnswer();
            }
        }
    }
}
