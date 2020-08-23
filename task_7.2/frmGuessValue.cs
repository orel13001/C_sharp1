using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_7._2
{
    public partial class frmGuessValue : Form
    {
        static Random rnd = new Random();
        public frmGuessValue()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Answer.SetGuessVal = rnd.Next(1, 101);
            Answer.UserAnswer();

        }
    }
}
