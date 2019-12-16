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

namespace Internal_Society
{
    public partial class activeFriend : UserControl
    {
        private string userName;
        private string userStatus;
        private string userAva;
        private int userLastLogin;
        private int NumOfUnSeenMessage = 0;
        public int ConversationID = -1;
        public int ColorID = 0;
        public activeFriend()
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

        private void UpdateLocalProperties(string userAva, string userName, string userStatus, int userLastLogin, int NumOfUnSeenMessage, int ConversationID)
        {
            this.userAva = userAva;
            this.userName = userName;
            this.userStatus = userStatus;
            this.userLastLogin = userLastLogin;
            this.NumOfUnSeenMessage = NumOfUnSeenMessage;
            this.ConversationID = ConversationID;
        }
        public activeFriend(string userAva, string userName, string userStatus, int userLastLogin, int NumOfUnSeenMessage, int ConversationID, int ColorID = 0)
        {
            InitializeComponent();
            this.ColorID = ColorID;
            UpdateLocalProperties(userAva, userName, userStatus, userLastLogin, NumOfUnSeenMessage, ConversationID);
            UpdateFriend();

        }

        public void UpdateFriend(string userAva, string userName, string userStatus, int userLastLogin, int NumOfUnSeenMessage, int ConversationID)
        {
            UpdateLocalProperties(userAva, userName, userStatus, userLastLogin, NumOfUnSeenMessage, ConversationID);
            UpdateFriend();
        }


        public void UpdateFriend()
        {

            Timer_Offline.Stop();
            Timer_Offline.Start();
            //MessageBox.Show(this.newMess.ToString());
            if (NumOfUnSeenMessage > 0 && onlineList.isViewing != this.ConversationID)
            {
                lbl_NewMess.Visible = true;
                lbl_NewMess.Text = NumOfUnSeenMessage.ToString();
                pictureBox2.Visible = true;
                //isClickedChatTab = false;
            }
            else
            {
                pictureBox2.Visible = false;
                lbl_NewMess.Visible = false;
            }
            //MessageBox.Show(this.userAva);
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

        public async void TurnOffNumOfMessage()
        {
            pictureBox2.Visible = false;
            lbl_NewMess.Visible = false;

            string urlSearchUser = App_Status.urlAPI + "c_Message/ReadMessage/" + ConversationID + "/" + User_Info.k_ID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;
        }

        private void Timer_Offline_Tick(object sender, EventArgs e)
        {
            Timer_Offline.Stop();
            UpdateFriend();
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
