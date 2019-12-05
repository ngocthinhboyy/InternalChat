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
using System.Web.Script.Serialization;

namespace Internal_Society
{
    public partial class Panel_Notification : UserControl
    {
        string data_notification = "";
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
                MessageBox.Show("Connection Error");
            }
            
            TimeRequest.Stop();
            TimeRequest.Start();
        }

        public void ShowNotification()
        {
            TimeRequest.Stop();
            TimeRequest.Start();
            List_Notification notiData = new JavaScriptSerializer().Deserialize<List_Notification>(data_notification);
            this.Controls.Clear();
            if (!notiData.success) return;

            int iTop = 10;
            int iLeft = 30;

            for (int i = notiData.data.Count - 1; i >= 0; i--)
            {
                if (notiData.data[i].type == "FriendRequest" && notiData.data[i].detail == "0") {
                    Notification_AddFriend ntAddFriend = new Notification_AddFriend(notiData.data[i].sender, Convert.ToInt32(notiData.data[i].sender));
                    ntAddFriend.Location = new Point(iLeft, 0);
                    ntAddFriend.Top = iTop + 20;
                    this.Controls.Add(ntAddFriend);
                    iTop = ntAddFriend.Bottom;
                }
                else if (notiData.data[i].type == "FriendRequest" && notiData.data[i].detail == "1")
                {
                    Notification_AcceptFriend ntAddFriend = new Notification_AcceptFriend(notiData.data[i].sender, Convert.ToInt32(notiData.data[i].sender));
                    ntAddFriend.Location = new Point(iLeft, 0);
                    ntAddFriend.Top = iTop + 20;
                    this.Controls.Add(ntAddFriend);
                    iTop = ntAddFriend.Bottom;
                }

            }
        }

        private void TimeRequest_Tick(object sender, EventArgs e)
        {
            TimeRequest.Stop();
            TimeRequest.Interval = 5000;
            GetDataAsync();
        }
    }
}
