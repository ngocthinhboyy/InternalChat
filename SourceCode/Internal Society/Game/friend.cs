using System;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class friend : UserControl
    {
        public int userID;
        public string userName;
        private string userStatus;
        private string userAva;
        private int userLastLogin;
        public friend()
        {
            InitializeComponent();
        }

        public void offlineStatus()
        {
            this.onlineIcon.Visible = false;
            this.offlineIcon.Visible = true;
        }
        public void onlineStatus()
        {
            this.onlineIcon.Visible = true;
            this.offlineIcon.Visible = false;
        }

        private void UpdateLocalProperties(string userAva, string userName, string userStatus, int userLastLogin)
        {
            this.userAva = userAva;
            this.userName = userName;
            this.userStatus = userStatus;
            this.userLastLogin = userLastLogin;
        }
        public friend(string userAva, string userName, string userStatus, int userLastLogin)
        {
            InitializeComponent();
            UpdateLocalProperties(userAva, userName, userStatus, userLastLogin);
            UpdateFriend();

        }

        public void UpdateFriend(string userAva, string userName, string userStatus, int userLastLogin)
        {
            UpdateLocalProperties(userAva, userName, userStatus, userLastLogin);
            UpdateFriend();
        }


        public void UpdateFriend()
        {

            if (this.userAva == "")
            {
                user_Avatar.ImageLocation = App_Status.urlLocalResources + "user_001.png";
            }
            else
            {
                user_Avatar.ImageLocation = App_Status.urlImage + "/image/" + this.userAva;

            }

            username.Text = this.userName;
            activeStatus.Text = this.userStatus;
            TimeSpan span = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            int time = (int)span.TotalSeconds;
            string sStatus = "";
            if (Internal_Society.Panel_Controls.tabPrivacySettings.activeStatus == true)
            {
                if (time - this.userLastLogin < 60) { sStatus = "Online"; onlineStatus(); }
                else { sStatus = countDeltaTime(time, this.userLastLogin); offlineStatus(); }
            }
            else
            {
                sStatus = "";
            }
            activeStatus.Text = sStatus;

        }

        private string countDeltaTime(int a, int b)
        {
            string result = "";
            if (((a - b) / 60) < 60) result = ((a - b) / 60).ToString() + ((((a - b) / 60) < 2) ? " minute" : " minutes") + " ago";
            else if (((a - b) / 60) < 1440) result = ((a - b) / 3600).ToString() + ((((a - b) / 3600) < 2) ? " hour " : " hours ") + ((a - b) % 60).ToString() + " minutes ago ";
            else result = ((a - b) / 86400).ToString() + ((((a - b) / 86400) < 2) ? " day" : "days") + " ago ";
            return result;
        }
    }
}
