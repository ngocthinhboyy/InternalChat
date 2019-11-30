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
        DateTime birthday = DateTime.Parse("2005-5-22");
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
        }
        public void ChangeDarkMode()
        {
            txt_Profile_Status.FillColor = txt_Profile_Birthday.FillColor = txt_Profile_Email.FillColor =
            txt_Profile_Gender.FillColor = txt_Profile_Name.FillColor = txt_Profile_Phone.FillColor
            = Color.FromArgb(255, App_Status.backFormColor.R, App_Status.backFormColor.G, App_Status.backFormColor.B);

            label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor =
            label5.ForeColor = label6.ForeColor = App_Status.textColor;
        }
        public void change_user_info(string edit_data_Name, string edit_data_Birthday, string edit_data_Gender, string edit_data_Phone, string edit_data_Email, string edit_data_Status)
        {
            var urlChange = "https://kunbr0.com/it008/change.php?id=" + k_user_id + "&type=fullname&value=" + edit_data_Name;
            string ChangeStatus = new WebClient().DownloadString(urlChange);
            urlChange = "https://kunbr0.com/it008/change.php?id=" + k_user_id + "&type=birthday&value=" + edit_data_Birthday;
            ChangeStatus = new WebClient().DownloadString(urlChange);
            urlChange = "https://kunbr0.com/it008/change.php?id=" + k_user_id + "&type=gender&value=" + edit_data_Gender;
            ChangeStatus = new WebClient().DownloadString(urlChange);
            urlChange = "https://kunbr0.com/it008/change.php?id=" + k_user_id + "&type=phone&value=" + edit_data_Phone;
            ChangeStatus = new WebClient().DownloadString(urlChange);
            urlChange = "https://kunbr0.com/it008/change.php?id=" + k_user_id + "&type=email&value=" + edit_data_Email;
            ChangeStatus = new WebClient().DownloadString(urlChange);
            urlChange = "https://kunbr0.com/it008/change.php?id=" + k_user_id + "&type=status&value=" + edit_data_Status;
            ChangeStatus = new WebClient().DownloadString(urlChange);
        }
        

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {
            txt_Profile_Birthday.Text = dateTime.Value.Year.ToString() + "-" + dateTime.Value.Month.ToString() + "-" + dateTime.Value.Day.ToString();
        }

        private void BtnEditPhoto_Click(object sender, EventArgs e)
        {

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
                var edit_data_Name = txt_Profile_Name.Text;
                var edit_data_Birthday = txt_Profile_Birthday.Text;
                var edit_data_Gender = txt_Profile_Gender.Text;
                var edit_data_Phone = txt_Profile_Phone.Text;
                var edit_data_Email = txt_Profile_Email.Text;
                var edit_data_Status = txt_Profile_Status.Text;
                MessageBox.Show(edit_data_Name);
                change_user_info(edit_data_Name, edit_data_Birthday, edit_data_Gender, edit_data_Phone, edit_data_Email, edit_data_Status);
            }
        }
    }
}
