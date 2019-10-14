using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace Internal_Society
{
    public partial class Panel_Profile : UserControl
    {

        string k_user_id;


        public Panel_Profile()
        {
            InitializeComponent();
            /*StreamReader read = new StreamReader("user_info.txt");
            string a1 = "";
            a1 = read.ReadLine();
            dynamic data_user = JsonConvert.DeserializeObject(a1);
            k_user_id = data_user.ID;
            txt_Profile_Name.Text = data_user.Fullname;
            txt_Profile_Birthday.Text = data_user.Birthday;
            txt_Profile_Gender.Text = data_user.Gender;
            txt_Profile_Phone.Text = data_user.Phone;
            txt_Profile_Email.Text = data_user.Email;
            txt_Profile_Status.Text = data_user.Status;*/

        }


        public void change_user_info(int func, string changeValue)
        {
            string changeType = "";

            switch (func)
            {
                case 1:
                    changeType = "fullname";
                    break;
                case 2:
                    changeType = "birthday";
                    break;
                case 3:
                    changeType = "gender";
                    break;
                case 4:
                    changeType = "phone";
                    break;
                case 5:
                    changeType = "email";
                    break;
                case 6:
                    changeType = "status";
                    break;


            }


            var urlChange = "https://kunbr0.com/it008/change.php?id=" + k_user_id + "&type=" + changeType + "&value=" + changeValue;
            string ChangeStatus = new WebClient().DownloadString(urlChange);
        }




        

        private void Edit_name_Click(object sender, EventArgs e)
        {
            if (edit_name.ImageLocation == "../../Resources/edit.png")
            {
                edit_name.ImageLocation = @"../../Resources/confirm.png";
                txt_Profile_Name.Enabled = true;

            }
            else
            {
                var edit_data = "";
                edit_data = txt_Profile_Name.Text;
                change_user_info(1, edit_data);
                edit_name.ImageLocation = @"../../Resources/edit.png";
                txt_Profile_Name.Enabled = false;
            }
        }

        private void Edit_birthday_Click(object sender, EventArgs e)
        {
            if (edit_birthday.ImageLocation == "../../Resources/edit.png")
            {
                txt_Profile_Birthday.Enabled = true;
                edit_birthday.ImageLocation = @"../../Resources/confirm.png";
            }
            else
            {
                var edit_data = "";
                edit_data = txt_Profile_Birthday.Text;
                change_user_info(2, edit_data);
                txt_Profile_Birthday.Enabled = false;
                edit_birthday.ImageLocation = @"../../Resources/edit.png";
            }
        }

        private void Edit_gender_Click(object sender, EventArgs e)
        {
            if (edit_gender.ImageLocation == "../../Resources/edit.png")
            {
                txt_Profile_Gender.Enabled = true;
                edit_gender.ImageLocation = @"../../Resources/confirm.png";
            }
            else
            {
                var edit_data = "";
                edit_data = txt_Profile_Gender.Text;
                change_user_info(3, edit_data);
                txt_Profile_Gender.Enabled = false;
                edit_gender.ImageLocation = @"../../Resources/edit.png";
            }
        }

        private void Edit_phone_Click(object sender, EventArgs e)
        {
            if (edit_phone.ImageLocation == "../../Resources/edit.png")
            {
                txt_Profile_Phone.Enabled = true;
                edit_phone.ImageLocation = @"../../Resources/confirm.png";
            }
            else
            {
                var edit_data = "";
                edit_data = txt_Profile_Phone.Text;
                change_user_info(4, edit_data);
                txt_Profile_Phone.Enabled = false;
                edit_phone.ImageLocation = @"../../Resources/edit.png";
            }
        }

        private void Edit_email_Click(object sender, EventArgs e)
        {
            if (edit_email.ImageLocation == "../../Resources/edit.png")
            {
                txt_Profile_Email.Enabled = true;
                edit_email.ImageLocation = @"../../Resources/confirm.png";
            }
            else
            {
                var edit_data = "";
                edit_data = txt_Profile_Email.Text;
                change_user_info(5, edit_data);
                txt_Profile_Email.Enabled = false;
                edit_email.ImageLocation = @"../../Resources/edit.png";
            }
        }

        private void Edit_status_Click(object sender, EventArgs e)
        {
            if (edit_status.ImageLocation == "../../Resources/edit.png")
            {
                txt_Profile_Status.Enabled = true;
                edit_status.ImageLocation = @"../../Resources/confirm.png";
            }
            else
            {
                var edit_data = "";
                edit_data = txt_Profile_Status.Text;
                change_user_info(6, edit_data);
                txt_Profile_Status.Enabled = false;
                edit_status.ImageLocation = @"../../Resources/edit.png";
            }
        }


    }
}
