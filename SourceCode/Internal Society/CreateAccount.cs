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

        string k_username;
        string k_ID;
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
            // call api de kiem tra username da ton tai hay chua
            if(false)
            {
                // kiem tra username da ton tai
                lblExistedAlert.Visible = true;
            }
            else if (txtPasswordCreate.Text != txtRepassword.Text)
            {
                // kiem tra password khong giong nhau
                lblUnmatchedAlert.Visible = true;
            }
            else
            {
                // create Thanh cong - mo trang add Information.
                CreateAccount_PersonalInfo personalInfoForm = new CreateAccount_PersonalInfo();
                this.Hide();
                personalInfoForm.ShowDialog();
                // mo ra Homepage sau khi user dang ky account thanh cong (KHONG CAN DANG NHAP LAI)
                HomePage homePageAfterCreating = new HomePage();
                homePageAfterCreating.ShowDialog();
                // chuyen checkCreate = 0 de khi close KHONG mo lai Login Form
                checkCreateAccountFormActive = 0;
                this.Close();
            }
        }

        // nut cancel de quay tro lai Login Form
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // chuyen checkCreate = 1 de khi cancel MO lai Login Form
            checkCreateAccountFormActive = 1;
            this.Close();
        }
    }
}
