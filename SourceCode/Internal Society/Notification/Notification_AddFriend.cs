using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

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

        void disableButton()
        {
            btn_Accept.Enabled = false;
            btn_Accept.Cursor = Cursors.No;
            btn_Remove.Enabled = false;
            btn_Remove.Cursor = Cursors.No;
        }

        void hideButton()
        {
            btn_Accept.Visible = false;
            btn_Remove.Visible = false;
        }
        public async void AcceptFriendAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "c_Friend/AcceptFriend/" + User_Info.k_ID + "/" + FriendID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;
            ProcessRespond(result);
        }

        public async void RemoveFriendAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "c_Friend/RemoveFriend/" + User_Info.k_ID + "/" + FriendID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;
            ProcessRespond(result);
        }

        void ProcessRespond(string result)
        {
            dynamic data = JsonConvert.DeserializeObject(result);
            if(data.Success.ToString() == "1") {
                hideButton();
                lb_Message.Text = data.Message.ToString();
                lb_Message.Visible = true;
            }
        }

        private void Btn_Accept1_Click(object sender, EventArgs e)
        {
            AcceptFriendAsync();
            //App_Status.notification--;
            //Panel_Notification.delegateNoti();
            disableButton();
        }


        private void Btn_Remove1_Click(object sender, EventArgs e)
        {
            RemoveFriendAsync();
            //App_Status.notification--;
            //Panel_Notification.delegateNoti();
            disableButton();
        }
    }
}
