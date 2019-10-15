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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        public int checkCreateAccountFormActive = 0;

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // kiem tra username da ton tai
            if(false)
            {
                lblExistedAlert.Visible = true;
            }
            else if (txtPasswordCreate.Text != txtRepassword.Text)
            {
                lblUnmatchedAlert.Visible = true;
            }
            else
            {
                CreateAccount_PersonalInfo personalInfoForm = new CreateAccount_PersonalInfo();
                this.Hide();
                personalInfoForm.ShowDialog();
                HomePage homePageAfterCreating = new HomePage();
                homePageAfterCreating.ShowDialog();
                checkCreateAccountFormActive = 0;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            checkCreateAccountFormActive = 1;
            this.Close();
        }
    }
}
