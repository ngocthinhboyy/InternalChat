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
        public activeFriend(string userName, string userStatus, int userLastLogin)
        {
            InitializeComponent();
            username.Text = userName;
            activeStatus.Text = userStatus;
            //MessageBox.Show(userLastLogin.ToString());

            TimeSpan span = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            int time = (int)span.TotalSeconds;

            string sStatus = "";
            if (time - userLastLogin < 60) { sStatus = "Online"; onlineStatus(); }
            else { sStatus = (time - userLastLogin) / 60 + " minutes ago"; offlineStatus(); }
            activeStatus.Text = sStatus;
        }




        
    }
}
