using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void StatusButtonLogin_NonProcess()
        {
            btnLogin.LabelText = "LOGIN";
            picture_process.Visible = false;
            btnLogin.color = Color.FromArgb(87, 184, 70);
            btnLogin.Enabled = true;
            btnRepresentLogin.Enabled = true;
        }

        // Tao hieu ung trong qua trinh cho doi trong luc dang nhap
        public void StatusButtonLogin_Process()
        {
            btnLogin.LabelText = "Please wait ...";
            picture_process.Visible = true;
            btnLogin.color = Color.FromArgb(128, 128, 128);
            btnLogin.Enabled = false;
            btnRepresentLogin.Enabled = false;
        }

        private async void LoginProcess()
        {
            var usernameLogin = txtUsername.Text;
            var passwordLogin = txtPassword.Text;
            string urlRequest = App_Status.urlAPI + "c_User/Login/" + usernameLogin + "/" + passwordLogin;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            StatusButtonLogin_Process();

            // await
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            FinishThread(data);
        }
        // ham dang nhap tao mot luong moi de xu ly dang nhap


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void BtnRepresentLogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }
        string kUTF8(string a)
        {
            string kq;
            byte[] bytes = Encoding.Default.GetBytes(a.ToString());
            return Encoding.UTF8.GetString(bytes);

        }
        public void FinishThread(dynamic LoginStatus)
        {
            StatusButtonLogin_NonProcess();
            if (LoginStatus.Success == "1")
            {
                // dang nhap thanh cong.
                // define
                User_Info.k_ID = LoginStatus.ID;
                User_Info.k_Username = LoginStatus.Username.ToString();
                User_Info.k_Fullname = LoginStatus.Fullname.ToString();
                User_Info.k_Diamond = LoginStatus.Diamond.ToString();
                User_Info.k_Gold = LoginStatus.Gold.ToString();
                User_Info.k_Gender = LoginStatus.Gender.ToString();
                User_Info.k_Phone = LoginStatus.Phone.ToString();
                User_Info.k_Email = LoginStatus.Email.ToString();
                User_Info.k_Birthday = LoginStatus.Birthday.ToString();
                User_Info.k_Status = LoginStatus.Status.ToString();
                User_Info.k_Address = LoginStatus.Address.ToString();
                User_Info.k_Avatar = LoginStatus.urlAvatar.ToString();


                // cho nguoi dung tien vao Homepage
                
                HomePage f1 = new HomePage();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                // dang nhap that bai - hien thi alert
                IncorrectAlert incorrect = new IncorrectAlert();
                incorrect.ShowDialog();
            }


        }

        #region Event Handler

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;

            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                var json = "Username";
                txtUsername.Text = json;
                txtUsername.ForeColor = Color.Silver;

            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;

            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;


            }
        }

        // mo Form CreateAccount cho nguoi dung tao tai khoan.
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount crForm = new CreateAccount();
            crForm.ShowDialog();
            // check dieu kien de dong tat LoginForm hop ly.
            /*
             *  bien checkCreate  de kiem tra:
             *      +   Neu An nut cancel o CreateAccount Form thi HIEN THI lai LoginForm ( checkCreate = 1 )
             *      +   Neu dang ky thanh cong va dang nhap vao HomepageForm thi Close luon chuong trinh ( checkCreate = 0 )
             */
            if (crForm.checkCreateAccountFormActive == 0)
                this.Close();
            else
                this.Show();
        }
        #endregion  

    }
}
