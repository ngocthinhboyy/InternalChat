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

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            // click vo skip hien thi ra IgnoringSecurityQuestionAlert form.
            IgnoringSecurityQuestionAlert ignoreAlert = new IgnoringSecurityQuestionAlert();
            this.Hide();
            ignoreAlert.ShowDialog();
            // check dieu kien de dong tat Create Account Personal Information hop ly.
            /*
             *  bien checkSureIgnore  de kiem tra:
             *      +   Neu An nut Skip o IgnoringSecurityQuestionAlert Form thi close Form nay de vao Homepage ( checkSureIgnore = 1 )
             *      +   Neu An nut Give me back o IgnoringSecurityQuestionAlert Form thi HIEN THI lai Form nay ( checkSureIgnore = 0 )
             */
            if (ignoreAlert.checkSureIgnore == 1 )
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
