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
    public partial class UserAsk : Form
    {
        public UserAsk()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Answer.Check(Convert.ToInt32(tbAnswer.Text));            
            this.Close();
        }
    }
}
