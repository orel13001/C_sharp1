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
    public partial class frmUdvoitel : Form
    {
        private int val = 0;

        public frmUdvoitel()
        {
            InitializeComponent();
        }

        public frmUdvoitel(int val)
        {
            this.val = val;
            InitializeComponent();            
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            lblResult.Text = Udvoitel.Btn_Click(((Button)sender).Name, Convert.ToInt32(lblResult.Text));
            lblComandCount.Text = Udvoitel.AddComandCount(Convert.ToInt32(lblComandCount.Text));
            if(Udvoitel.CompareValue(Convert.ToInt32(lblResult.Text), Convert.ToInt32(lblMustGet.Text)))
            {
                MessageBox.Show($"Вы получили число за {lblComandCount.Text} ходов");
                this.Close();
            }
        }

        private void btnMultTwo_Click(object sender, EventArgs e)
        {
            lblResult.Text = Udvoitel.Btn_Click(((Button)sender).Name, Convert.ToInt32(lblResult.Text));
            lblComandCount.Text = Udvoitel.AddComandCount(Convert.ToInt32(lblComandCount.Text));
            if (Udvoitel.CompareValue(Convert.ToInt32(lblResult.Text), Convert.ToInt32(lblMustGet.Text)))
            {
                MessageBox.Show($"Вы получили число за {lblComandCount.Text} ходов");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblResult.Text = Udvoitel.Btn_Click(((Button)sender).Name, Convert.ToInt32(lblResult.Text));
            lblComandCount.Text = "0";
        }

        private void btnCancelStep_Click(object sender, EventArgs e)
        {
            lblResult.Text = Udvoitel.PopStack();
            lblComandCount.Text = (Convert.ToInt32(lblComandCount.Text)-1).ToString();
        }
    }
}
