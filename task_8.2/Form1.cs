using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_8._2
{
    public partial class Form1 : Form, IView
    {
        Logic logic;

        public Form1()
        {
            InitializeComponent();
        }

        public string InputVal { get { return nudSelect.Value.ToString(); } }

        public string OutputVal { set { tbResult.Text = value; } }


        private void nudSelect_ValueChanged(object sender, EventArgs e)
        {
            logic.GiveValue();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logic = new Logic(this);
            logic.GiveValue();
        }
    }
}
