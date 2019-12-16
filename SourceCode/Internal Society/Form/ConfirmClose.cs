using System;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class ConfirmClose : Form
    {
        public ConfirmClose()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage.isExit = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
