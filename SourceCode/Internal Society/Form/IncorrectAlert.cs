using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class IncorrectAlert : Form
    {
        public IncorrectAlert()
        {
            InitializeComponent();
        }
        public IncorrectAlert(string alert)
        {
            InitializeComponent();
            label1.Text = alert;
        }
        private void BtnIncorrect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRepresentIncorrect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
