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
    public partial class friendInfo : UserControl
    {
        int FriendID;
        public friendInfo()
        {
            InitializeComponent();
        }
        public friendInfo(string userName, string userFullname, int FriendID)
        {
            this.FriendID = FriendID;
            InitializeComponent();
            username.Text = userName;
            if (userFullname == "")
            {
                userFullname = "Người dùng Internal Chat";
            }
            user_fullname.Text = userFullname;
        }

        public async void AddFriendAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "c_Friend/AddFriend/" + User_Info.k_ID + "/" + FriendID;
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

        bool isClicked = false;

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                AddFriendAsync();
                btn_addFriend.IdleFillColor = Color.FromArgb(227, 38, 54);
                //btn_addFriend.Normalcolor = Color.FromArgb(227, 38, 54);
                //btn_addFriend.OnHovercolor = Color.FromArgb(217, 38, 54);
                btn_addFriend.ButtonText = "Remove request";
                isClicked = !isClicked;
            }
            else
            {
                RemoveFriendAsync();
                btn_addFriend.IdleFillColor = Color.DeepPink;
                //btn_addFriend.Normalcolor = Color.FromArgb(46, 139, 87);
                //btn_addFriend.OnHovercolor = Color.FromArgb(36, 129, 77);
                btn_addFriend.ButtonText = "Add friend";
                isClicked = !isClicked;
            }

        }
    }
}
