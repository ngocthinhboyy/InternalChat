using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class CreateAccount : Form
    {


        string usernameInDBStatus = "0";
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
            CheckCorrect();
            // call api de kiem tra username da ton tai hay chua
            if(txtRepassword.Text != txtPasswordCreate.Text)
            {
                lblUnmatchedAlert.Visible = true;
            }
            else
            {
                lblUnmatchedAlert.Visible = false;
            }
            if (txtPasswordCreate.Text != "" && txtUsernameCreate.Text != "" && usernameInDBStatus != "1" && txtRepassword.Text == txtPasswordCreate.Text)
            {

                Reg_Info.reg_Username = txtUsernameCreate.Text;
                Reg_Info.reg_Password = txtPasswordCreate.Text;


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
        private void CheckCorrect()
        {
            var urlCheckUsername = "https://kunbr0.com/it008/check_exist.php?us=" + txtUsernameCreate.Text;
            usernameInDBStatus = new WebClient().DownloadString(urlCheckUsername);


            if (txtUsernameCreate.Text == "")
            {
                // kiem tra username da ton tai
                lblExistedAlert.Visible = false;
                lblNullUsername.Visible = true;
            }
            else if (usernameInDBStatus == "1")
            {

                lblExistedAlert.Visible = true;
                lblNullUsername.Visible = false;
            }
            else
            {
                lblNullUsername.Visible = false;
                lblExistedAlert.Visible = false;
            }
        }
        private void TxtUsernameCreate_Leave(object sender, EventArgs e)
        {



            CheckCorrect();
        }

        private void TxtPasswordCreate_Leave(object sender, EventArgs e)
        {
            if(txtPasswordCreate.Text == "")
            {
                lblNullPassword.Visible = true;
            }
            else
            {
                lblNullPassword.Visible = false;
            }
        }
    }
}
