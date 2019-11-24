using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using Newtonsoft.Json;

namespace Internal_Society
{
    public partial class onlineList : UserControl
    {
        public onlineList()
        {
            InitializeComponent();
        }
        string listUsers = "";

        public async void GetDataAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "c_Friend/Get_FriendList/" + User_Info.k_ID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;
            if (result != listUsers)
            {
                listUsers = result;
                ShowOnlineUser();
            }
            TimeRequest.Stop();
            TimeRequest.Start();
        }

        public void ShowOnlineUser()
        {
            label1.Visible = false;

            if (listUsers != "")
            {
                this.Controls.Clear();
                label1.Visible = false;
                List<Friend_Info> userArr = new List<Friend_Info>();
                userArr = JsonConvert.DeserializeObject<List<Friend_Info>>(listUsers);
                if (userArr.Count() > 0)
                {
                    activeFriend friend_last = new activeFriend(userArr[0].friend_Username, userArr[0].friend_Fullname,
                        userArr[0].friend_lastLogin);
                    friend_last.Top = 0 - friend_last.Height + 10;
                    for (int i = 0; i < userArr.Count(); i++)
                    {
                        activeFriend friend = new activeFriend(userArr[i].friend_Username, userArr[i].friend_Fullname,
                            userArr[i].friend_lastLogin);
                        friend.Location = new Point(10, 0);
                        friend.Top = friend_last.Bottom + 20;
                        
                        friend.Width = this.Width - 20;
                        friend.Tag = userArr[i].friend_Conversation_ID.ToString();
                        
                        friend.Click += Friend_Click;


                        this.Controls.Add(friend);
                        //this.VerticalScroll.Value = this.VerticalScroll.Maximum;
                        //this.VerticalScroll.Visible = false;
                        friend_last = friend;

                        
                    }
                }

                if (listUsers == "[]")
                {
                    label1.Visible = true;
                    this.Controls.Add(label1);
                }
            }
        }

        private void TimeRequest_Tick(object sender, EventArgs e)
        {
            TimeRequest.Stop();
            GetDataAsync();
        }

        public event EventHandler FriendClicked;
        protected virtual void OnFriendClicked(object sender, EventArgs e)
        {
            var handler = FriendClicked;
            
            if (handler != null)
                handler(sender,e);
        }
        private void Friend_Click(object sender, EventArgs e)
        {
            //While you can call `this.ParentForm.Close()` it's better to raise an event
            OnFriendClicked(sender,e);
        }
    }
}
