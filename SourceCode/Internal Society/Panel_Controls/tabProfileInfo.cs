﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Internal_Society.Panel_Controls
{
    public delegate void ChangeAva();
    public partial class tabProfileInfo : UserControl
    {
        string k_user_id;
        public static ChangeAva delegateChangeAva;
        string vBirthday = User_Info.k_Birthday;

        public tabProfileInfo()
        {

            InitializeComponent();
            Male.Checked = false;
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeProfileInfo = new Panel_Controls.DarkMode(this.ChangeDarkMode);

            if (vBirthday == null || vBirthday == "")
            {
                vBirthday = "2000-01-01";
            }
            DateTime birthday = DateTime.Parse(vBirthday);
            k_user_id = User_Info.k_ID;
            txt_Profile_Name.Text = User_Info.k_Fullname;
            txt_Profile_Birthday.Text = birthday.Year.ToString() + "-" + birthday.Month.ToString() + "-" + birthday.Day.ToString();
            if (User_Info.k_Gender == "0")
            {
                Male.Checked = true;
            }
            else
            {
                if (User_Info.k_Gender == "1")
                    Female.Checked = true;
                else
                    Undefined.Checked = true;
            }
            txt_Profile_Phone.Text = User_Info.k_Phone;
            txt_Profile_Email.Text = User_Info.k_Email;
            txt_Profile_Address.Text = User_Info.k_Address;

            if (User_Info.k_Avatar == "")
            {
                pb_Avatar.ImageLocation = App_Status.urlLocalResources + "user_001.png";
            }
            else
            {
                pb_Avatar.ImageLocation = App_Status.urlImage + "/image/" + User_Info.k_Avatar;
            }

        }
        public void ChangeDarkMode()
        {
            txt_Profile_Address.FillColor = txt_Profile_Birthday.FillColor = txt_Profile_Email.FillColor
            = txt_Profile_Name.FillColor = txt_Profile_Phone.FillColor
            = Color.FromArgb(255, App_Status.backFormColor.R, App_Status.backFormColor.G, App_Status.backFormColor.B);

            txt_Profile_Address.ForeColor = txt_Profile_Birthday.ForeColor = txt_Profile_Email.ForeColor
             = txt_Profile_Name.ForeColor = txt_Profile_Phone.ForeColor
            = label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor =
            label5.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor = label9.ForeColor = App_Status.textColor;
        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {
            txt_Profile_Birthday.Text = dateTime.Value.Year.ToString() + "-" + dateTime.Value.Month.ToString() + "-" + dateTime.Value.Day.ToString();
        }



        private void BtnEditPhoto_Click(object sender, EventArgs e)
        {
            FileUpload fu = new FileUpload(App_Status.urlUpload, "-1", "avatar");
            if (fu.UploadFile("image"))
            {
                pb_Avatar.ImageLocation = fu.FilePath;
                User_Info.localAvatar = fu.FilePath;
                delegateChangeAva();
            }

        }

        private void BtnEditInfo_Click(object sender, EventArgs e)
        {
            if (btnEditInfo.ButtonText == "Edit Information")
            {
                txt_Profile_Name.Enabled = true;
                Male.Enabled = Female.Enabled = Undefined.Enabled = true;
                txt_Profile_Phone.Enabled = true;
                txt_Profile_Email.Enabled = true;
                txt_Profile_Address.Enabled = true;
                dateTime.Enabled = true;
                btnEditInfo.ButtonText = "Save";
            }
            else
            {
                btnEditInfo.ButtonText = "Edit Information";
                txt_Profile_Name.Enabled = false;
                Male.Enabled = Female.Enabled = Undefined.Enabled = false;
                txt_Profile_Phone.Enabled = false;
                txt_Profile_Email.Enabled = false;
                txt_Profile_Address.Enabled = false;
                dateTime.Enabled = false;

                User_Info.k_Fullname = txt_Profile_Name.Text;
                User_Info.k_Birthday = txt_Profile_Birthday.Text;
                if (Male.Checked == true)
                {
                    User_Info.k_Gender = "0";
                }
                else
                {
                    if (Female.Checked == true)
                        User_Info.k_Gender = "1";
                    else
                        User_Info.k_Gender = "2";
                }
                User_Info.k_Phone = txt_Profile_Phone.Text;
                User_Info.k_Email = txt_Profile_Email.Text;
                User_Info.k_Address = txt_Profile_Address.Text;
                User_Info.UpdateUserInfo();
            }
        }
    }
}
