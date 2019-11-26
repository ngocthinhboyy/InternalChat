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
    public partial class Notification_AddFriend : UserControl
    {
        int FriendID;
        public Notification_AddFriend()
        {
            InitializeComponent();
        }

        public Notification_AddFriend(string fullname, int FriendID)
        {
            InitializeComponent();
            this.FriendID = FriendID;
            lb_Fullname.Text = fullname;
        }

        public async void AcceptFriendAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "c_Friend/AcceptFriend/" + User_Info.k_ID + "/" + FriendID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;

        }

        public async void RemoveFriendAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "c_Friend/RemoveFriend/" + User_Info.k_ID + "/" + FriendID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;

        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            AcceptFriendAsync();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            RemoveFriendAsync();
        }
    }
}
