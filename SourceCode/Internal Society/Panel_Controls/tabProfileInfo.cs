using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Internal_Society.Panel_Controls
{
    public partial class tabProfileInfo : UserControl
    {
        string k_user_id;
        DateTime birthday = DateTime.Parse("2005-05-22");
        //MessageBox.Show(User_Info.k_Birthday);
        //DateTime birthday = DateTime.Parse(User_Info.k_Birthday);
        public tabProfileInfo()
        {

            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeProfileInfo = new Panel_Controls.DarkMode(this.ChangeDarkMode);
           

            k_user_id = User_Info.k_ID;
            txt_Profile_Name.Text = User_Info.k_Fullname;
            txt_Profile_Birthday.Text = birthday.Year.ToString() + "-" + birthday.Month.ToString() + "-" + birthday.Day.ToString();
            if (User_Info.k_Gender == "1")
            {
                txt_Profile_Gender.Text = "Male";
            }
            else
            {
                txt_Profile_Gender.Text = "Female";
            }
            txt_Profile_Phone.Text = User_Info.k_Phone;
            txt_Profile_Email.Text = User_Info.k_Email;
            txt_Profile_Status.Text = User_Info.k_Status;
            
            if(User_Info.k_Avatar == "")
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
            txt_Profile_Status.FillColor = txt_Profile_Birthday.FillColor = txt_Profile_Email.FillColor =
            txt_Profile_Gender.FillColor = txt_Profile_Name.FillColor = txt_Profile_Phone.FillColor
            = Color.FromArgb(255, App_Status.backFormColor.R, App_Status.backFormColor.G, App_Status.backFormColor.B);

            txt_Profile_Status.ForeColor = txt_Profile_Birthday.ForeColor = txt_Profile_Email.ForeColor =
            txt_Profile_Gender.ForeColor = txt_Profile_Name.ForeColor = txt_Profile_Phone.ForeColor
            = label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor =
            label5.ForeColor = label6.ForeColor = App_Status.textColor;
        }
        
        private void DateTime_ValueChanged(object sender, EventArgs e)
        {
            txt_Profile_Birthday.Text = dateTime.Value.Year.ToString() + "-" + dateTime.Value.Month.ToString() + "-" + dateTime.Value.Day.ToString();
        }



        private void BtnEditPhoto_Click(object sender, EventArgs e)
        {
            FileUpload fu = new FileUpload(App_Status.urlUpload, "-1");
            if (fu.UploadFile())
            {
                pb_Avatar.ImageLocation = fu.FilePath;
            }
            User_Info.k_Avatar = fu.FilePath;
        }

        private void BtnEditInfo_Click(object sender, EventArgs e)
        {
            if (btnEditInfo.ButtonText == "Edit Information")
            {
                txt_Profile_Name.Enabled = true;
                txt_Profile_Gender.Enabled = true;
                txt_Profile_Phone.Enabled = true;
                txt_Profile_Email.Enabled = true;
                txt_Profile_Status.Enabled = true;
                dateTime.Enabled = true;
                //MessageBox.Show(dateTime.Value.ToString());
                btnEditInfo.ButtonText = "Save";
            }
            else
            {
                btnEditInfo.ButtonText = "Edit Information";
                txt_Profile_Name.Enabled = false;
                txt_Profile_Gender.Enabled = false;
                txt_Profile_Phone.Enabled = false;
                txt_Profile_Email.Enabled = false;
                txt_Profile_Status.Enabled = false;
                dateTime.Enabled = false;

                User_Info.k_Fullname = txt_Profile_Name.Text;
                User_Info.k_Birthday = txt_Profile_Birthday.Text;
                User_Info.k_Gender = txt_Profile_Gender.Text;
                User_Info.k_Phone = txt_Profile_Phone.Text;
                User_Info.k_Email = txt_Profile_Email.Text;
                User_Info.k_Status = txt_Profile_Status.Text;
                //MessageBox.Show(edit_data_Name);
                User_Info.UpdateUserInfo();
                //change_user_info(edit_data_Name, edit_data_Birthday, edit_data_Gender, edit_data_Phone, edit_data_Email, edit_data_Status);
            }
        }
    }
}
