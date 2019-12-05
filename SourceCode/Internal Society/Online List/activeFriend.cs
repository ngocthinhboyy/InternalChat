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
    public partial class activeFriend : UserControl
    {
        private string userName;
        private string userStatus;
        private int userLastLogin;

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

        private void UpdateLocalProperties(string userName, string userStatus, int userLastLogin)
        {
            this.userName = userName;
            this.userStatus = userStatus;
            this.userLastLogin = userLastLogin;
        }
        public activeFriend(string userName, string userStatus, int userLastLogin)
        {
            InitializeComponent();

            UpdateLocalProperties(userName, userStatus, userLastLogin);
            UpdateFriend();

        }

        public void UpdateFriend(string userName, string userStatus, int userLastLogin)
        {
            UpdateLocalProperties(userName, userStatus, userLastLogin);
            UpdateFriend();
        }

        public void UpdateFriend()
        {
            
            Timer_Offline.Stop();
            Timer_Offline.Start();
            username.Text = this.userName;
            activeStatus.Text = this.userStatus;
            TimeSpan span = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            int time = (int)span.TotalSeconds;

            string sStatus = "";
            
            if (time - this.userLastLogin < 60) { sStatus = "Online"; onlineStatus(); }
            else { sStatus = (time - this.userLastLogin) / 60 + " minutes ago"; offlineStatus(); }
            activeStatus.Text = sStatus;
        }

        private void Timer_Offline_Tick(object sender, EventArgs e)
        {
            Timer_Offline.Stop();
            UpdateFriend();
        }
    }
}
