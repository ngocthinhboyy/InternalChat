﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Internal_Society
{

    public partial class LoginForm : Form
    {
        

        string LoginStatus = "-99";


        


        public LoginForm()
        {
            InitializeComponent();
        }

        public void threadLogin()
        {
            
            var usernameLogin = txtUsername.Text;
            var passwordLogin = txtPassword.Text;
            var urlLogin = "https://kunbr0.com/it008/login.php?us=" + usernameLogin + "&ps=" + passwordLogin;
            LoginStatus = new WebClient().DownloadString(urlLogin);
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

        // ham dang nhap tao mot luong moi de xu ly dang nhap
        public void ClickLogin()
        {

            LoginStatus = "-99";

            StatusButtonLogin_Process();

            ThreadStart ts_1 = new ThreadStart(threadLogin);
            Thread thrd_1 = new Thread(ts_1);
            thrd_1.Start();

            TimeLogin.Start();

            

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ClickLogin();
        }

        private void BtnRepresentLogin_Click(object sender, EventArgs e)
        {
            ClickLogin();
        }

        private void TimeLogin_Tick(object sender, EventArgs e)
        {
            if(LoginStatus != "-99")
            {
                TimeLogin.Stop();
                StatusButtonLogin_NonProcess();

                if (LoginStatus != "-1")
                {
                    // dang nhap thanh cong.
                    File.WriteAllText("user_info.txt", String.Empty);

                    StreamWriter kWrite = new StreamWriter("user_info.txt", true);
                    dynamic data_user = JsonConvert.DeserializeObject(LoginStatus);

                    string inputFile = "{\"ID\":\"" + data_user.ID + "\",\"Fullname\":\"" + data_user.Fullname + "\",\"Diamond\":\"" + data_user.Diamond + "\",\"Gold\":\"" + data_user.Gold + "\",\"Gender\":\"" + data_user.Gender + "\",\"Phone\":\"" + data_user.Phone + "\",\"Email\":\"" + data_user.Email + "\",\"Birthday\":\"" + data_user.Birthday + "\",\"Status\":\"" + data_user.Status + "\",\"Address\":\"" + data_user.Address + "\"}";

                    kWrite.WriteLine(inputFile);
                    kWrite.Close();
                    // define

                    User_Info.k_ID = data_user.ID;
                    User_Info.k_Username = data_user.Username;
                    User_Info.k_Fullname = data_user.Fullname;
                    User_Info.k_Diamond = data_user.Diamond;
                    User_Info.k_Gold = data_user.Gold;
                    User_Info.k_Gender = data_user.Gender;
                    User_Info.k_Phone = data_user.Phone;
                    User_Info.k_Email = data_user.Email;
                    User_Info.k_Birthday = data_user.Birthday;
                    User_Info.k_Status = data_user.Status;
                    User_Info.k_Address = data_user.Address;



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
        }

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
            txtPassword.UseSystemPasswordChar = true;
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
    }
}