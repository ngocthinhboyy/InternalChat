using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //private int NumOfUnSeenMessage = 0;
       // public int ConversationID = -1;
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
            //this.NumOfUnSeenMessage = NumOfUnSeenMessage;
            //this.ConversationID = ConversationID;
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
                else { sStatus = (time - this.userLastLogin) / 60 + " minutes ago"; offlineStatus(); }
            }
            else
            {
                sStatus = "";
            }
            activeStatus.Text = sStatus;

        }


    }
}
