using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class CreateAccount_PersonalInfo : Form
    {
        string data;
        public CreateAccount_PersonalInfo()
        {
            InitializeComponent();
        }
        string kUTF8(string a)
        {
            string kq;
            byte[] bytes = Encoding.Default.GetBytes(a.ToString());
            return Encoding.UTF8.GetString(bytes);

        }
        private void Process_Register()
        {
            if (Reg_Info.reg_Nickname == "") Reg_Info.reg_Nickname = Reg_Info.reg_Username;
            var urlCreateUser = App_Status.urlAPI + "c_User/Reg/" + Reg_Info.reg_Username + "/" + Reg_Info.reg_Password + "/" + Reg_Info.reg_Nickname + "/" + Reg_Info.reg_Question_1 + "/" + Reg_Info.reg_Answer_1 + "/" + Reg_Info.reg_Question_2 + "/" + Reg_Info.reg_Answer_2;
            string data1 = new WebClient().DownloadString(urlCreateUser);
            dynamic data2 = JsonConvert.DeserializeObject(data1);
            string userRegisterStatus = data2.Success;
            if (userRegisterStatus == "1")
            {
                var urlLogin = App_Status.urlAPI + "c_User/Login/" + Reg_Info.reg_Username + "/" + Reg_Info.reg_Password;
                data = new WebClient().DownloadString(urlLogin);
                dynamic LoginStatus = JsonConvert.DeserializeObject(data);
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
                User_Info.k_LastNoti = LoginStatus.lastNotification.ToString();
                User_Info.k_LuckyWheel = LoginStatus.LuckyKey.ToString();
                User_Info.k_DarkMode = (LoginStatus.DarkMode.ToString() == "1") ? true : false;
                User_Info.k_SearchAvailable = (LoginStatus.SearchAvailable.ToString() == "1") ? true : false;
                User_Info.k_SeeProfileAvailable = (LoginStatus.SeeProfileAvailable.ToString() == "1") ? true : false;
            }

        }

        private void iniStatus(Graphics g)
        {
            Pen p = new Pen(Color.Green);
            txtNickname.BorderStyle = BorderStyle.None;
            g.DrawRectangle(p, new Rectangle(txtNickname.Location.X - 3, txtNickname.Location.Y - 3, txtNickname.Width + 3, txtNickname.Height + 3));
            txtAnswer1.BorderStyle = BorderStyle.None;
            g.DrawRectangle(p, new Rectangle(txtAnswer1.Location.X - 3, txtAnswer1.Location.Y - 3, txtAnswer1.Width + 3, txtAnswer1.Height + 3));
            txtAnswer2.BorderStyle = BorderStyle.None;
            g.DrawRectangle(p, new Rectangle(txtAnswer2.Location.X - 3, txtAnswer2.Location.Y - 3, txtAnswer2.Width + 3, txtAnswer2.Height + 3));
        }
        private bool CheckNullPersonalInfor()
        {
            Pen p = new Pen(Color.Red);
            Graphics g = panel1.CreateGraphics();
            int strong = 3;
            iniStatus(g);
            if (txtNickname.Text == "")
            {
                txtNickname.BorderStyle = BorderStyle.None;
                g.DrawRectangle(p, new Rectangle(txtNickname.Location.X - strong, txtNickname.Location.Y - strong, txtNickname.Width + strong, txtNickname.Height + strong));
            }
            if (txtAnswer1.Text == "")
            {
                txtAnswer1.BorderStyle = BorderStyle.None;
                g.DrawRectangle(p, new Rectangle(txtAnswer1.Location.X - strong, txtAnswer1.Location.Y - strong, txtAnswer1.Width + strong, txtAnswer1.Height + strong));
            }
            if (txtAnswer2.Text == "")
            {
                txtAnswer2.BorderStyle = BorderStyle.None;
                g.DrawRectangle(p, new Rectangle(txtAnswer2.Location.X - strong, txtAnswer2.Location.Y - strong, txtAnswer2.Width + strong, txtAnswer2.Height + strong));
            }
            if (txtNickname.Text == "" || txtAnswer1.Text == "" || txtAnswer2.Text == "")
                return false;
            return true;
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if (CheckNullPersonalInfor())
            {
                Reg_Info.reg_Nickname = txtNickname.Text;
                Reg_Info.reg_Question_1 = question1.selectedIndex;
                Reg_Info.reg_Question_2 = question2.selectedIndex;
                Reg_Info.reg_Answer_1 = txtAnswer1.Text;
                Reg_Info.reg_Answer_2 = txtAnswer2.Text;
                Process_Register();
                this.Close();
            }

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
            if (ignoreAlert.checkSureIgnore == 1)
            {
                Process_Register();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
