using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;

namespace Internal_Society
{
    public delegate void Notification();
    public partial class Panel_Notification : UserControl
    {
        string data_notification = "";
        public static Notification delegateNoti;
        public static string lastNoti;
        public Panel_Notification()
        {
            InitializeComponent();
        }

        public async void GetDataAsync()
        {
            try
            {
                string urlGetNotification = App_Status.urlAPI + "c_Notification/Get_Notification/" + User_Info.k_ID;
                Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlGetNotification); });
                // await
                string result = await getStringTask;
                if (result != data_notification)
                {
                    data_notification = result;
                    ShowNotification();
                }
            }
            catch
            {
                IncorrectAlert alert = new IncorrectAlert("Connection Error");
                alert.Show();
            }

            TimeRequest.Stop();
            TimeRequest.Start();
        }
        public void ShowNotification()
        {
            TimeRequest.Stop();
            TimeRequest.Start();
            List_Notification notiData = new JavaScriptSerializer().Deserialize<List_Notification>(data_notification);
            //Count();
            lastNoti = notiData.data[0].id;
            this.Controls.Clear();
            if (!notiData.success) return;
            int iTop = 10;
            int iLeft = 30;
            App_Status.notification = 0;
            int dem = 1;
            for (int i = notiData.data.Count - 1; i >= 0; i--)
            {
                if (notiData.data[i].id.ToString() != User_Info.k_LastNoti)
                {
                    dem++;
                }
                else break;
            }
            for (int i = notiData.data.Count - 1; i >= 0; i--)
            {

                if (notiData.data[i].type == "FriendRequest" && notiData.data[i].detail == "0")
                {
                    Notification_AddFriend ntAddFriend = new Notification_AddFriend(notiData.data[i].sender_fullname, Convert.ToInt32(notiData.data[i].sender));
                    ntAddFriend.Location = new Point((this.Width - ntAddFriend.Width) / 2, 0);
                    ntAddFriend.Top = iTop + 20;
                    this.Controls.Add(ntAddFriend);
                    iTop = ntAddFriend.Bottom;
                }
                else if (notiData.data[i].type == "FriendRequest" && notiData.data[i].detail == "1")
                {
                    Notification_AcceptFriend ntAddFriend = new Notification_AcceptFriend(notiData.data[i].sender_fullname, Convert.ToInt32(notiData.data[i].sender));
                    ntAddFriend.Location = new Point((this.Width - ntAddFriend.Width) / 2, 0);
                    ntAddFriend.Top = iTop + 20;
                    this.Controls.Add(ntAddFriend);
                    iTop = ntAddFriend.Bottom;
                }
                else if (notiData.data[i].type == "CaroInvite")
                {
                    NotiCaro ntAddFriend = new NotiCaro(notiData.data[i].sender_fullname, Convert.ToInt32(notiData.data[i].detail));
                    ntAddFriend.Location = new Point((this.Width - ntAddFriend.Width) / 2, 0);
                    ntAddFriend.Top = iTop + 20;
                    this.Controls.Add(ntAddFriend);
                    iTop = ntAddFriend.Bottom;
                }
            }

            App_Status.notification = Math.Abs(notiData.data.Count - dem);
            delegateNoti();
        }
        private void TimeRequest_Tick(object sender, EventArgs e)
        {
            TimeRequest.Stop();
            TimeRequest.Interval = 5000;
            GetDataAsync();
        }

        private void Panel_Notification_Resize(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Left = (this.Width - item.Width) / 2;
            }
        }
    }
}
