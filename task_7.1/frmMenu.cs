using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_7._1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int val = Udvoitel.rnd.Next(0, 101);
            MessageBox.Show($"Получите число {val} за минимальное число ходов");
            new frmUdvoitel(val).Show();
        }
    }
}
