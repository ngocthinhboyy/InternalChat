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
    public partial class CreateAccount_PersonalInfo : Form
    {
        public CreateAccount_PersonalInfo()
        {
            InitializeComponent();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
