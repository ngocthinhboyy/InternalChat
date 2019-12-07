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
    public partial class IgnoringSecurityQuestionAlert : Form
    {
        public int checkSureIgnore = 0;
        public IgnoringSecurityQuestionAlert()
        {
            InitializeComponent();
        }

        private void BtnGiveBack_Click(object sender, EventArgs e)
        {
            // chuyen checkSureIgnore = 0 de khi Give me back MO lai CreateAccountPersonalnformation Form
            checkSureIgnore = 0;
            this.Close();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            // chuyen checkSureIgnore = 1 de khi Skip cho user dang nhap vao ung dung - mo HOMEPAGE
            checkSureIgnore = 1;
            this.Close();
        }
        
    }
}
