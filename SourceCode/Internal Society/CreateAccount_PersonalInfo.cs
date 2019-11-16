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
    public partial class CreateAccount_PersonalInfo : Form
    {
        string LoginStatus;
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
            var urlCreateUser = "https://kunbr0.com/it008/reg.php?us=" + Reg_Info.reg_Username + "&ps=" + Reg_Info.reg_Password + "&nickname=" + Reg_Info.reg_Nickname + "&ques_1=" + Reg_Info.reg_Question_1 + "&ans_1=" + Reg_Info.reg_Answer_1 + "&ques_2=" + Reg_Info.reg_Question_2 + "&ans_2=" + Reg_Info.reg_Answer_2;
            string userRegisterStatus = new WebClient().DownloadString(urlCreateUser);
            if(userRegisterStatus == "1")
            {
                var urlLogin = "https://kunbr0.com/it008/login.php?us=" + Reg_Info.reg_Username + "&ps=" + Reg_Info.reg_Password;
                LoginStatus = new WebClient().DownloadString(urlLogin);
                dynamic data_user = JsonConvert.DeserializeObject(LoginStatus);
                User_Info.k_ID = data_user.ID;
                User_Info.k_Username = kUTF8(data_user.Username.ToString());
                User_Info.k_Fullname = kUTF8(data_user.Fullname.ToString());
                User_Info.k_Diamond = kUTF8(data_user.Diamond.ToString());
                User_Info.k_Gold = kUTF8(data_user.Gold.ToString());
                User_Info.k_Gender = kUTF8(data_user.Gender.ToString());
                User_Info.k_Phone = kUTF8(data_user.Phone.ToString());
                User_Info.k_Email = kUTF8(data_user.Email.ToString());
                User_Info.k_Birthday = kUTF8(data_user.Birthday.ToString());
                User_Info.k_Status = kUTF8(data_user.Status.ToString());
                User_Info.k_Address = kUTF8(data_user.Address.ToString());
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
            if ( txtAnswer1.Text == "")
            {
                txtAnswer1.BorderStyle = BorderStyle.None;
                g.DrawRectangle(p, new Rectangle(txtAnswer1.Location.X - strong, txtAnswer1.Location.Y - strong, txtAnswer1.Width + strong, txtAnswer1.Height + strong));
            }
            if( txtAnswer2.Text == "")
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
            if(CheckNullPersonalInfor())
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
            if (ignoreAlert.checkSureIgnore == 1 )
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
