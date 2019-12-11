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
using System.Web.Script.Serialization;

namespace Internal_Society
{

    public partial class onlineList : UserControl
    {

        public static int isViewing = -1;

        List<int> ListIDOnline = new List<int>();

        bool isExist(List<int> kList, int a)
        {
            foreach (int item in kList)
            {
                if (item == a) return true;
            }
            return false;
        }

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
            label_NoActiveFriend.Visible = false;

            if (listUsers == "") return;
            ListUserOnline userArr = new JavaScriptSerializer().Deserialize<ListUserOnline>(listUsers);

            if (!userArr.success)
            {
                label_NoActiveFriend.Visible = true;
                return;
            }
            if (userArr.data.Count() > 0)
            {
                activeFriend friend_last = new activeFriend("", "",
                    0, 0, 0);
                friend_last.Top = 0 - friend_last.Height + 10;
                for (int i = 0; i < userArr.data.Count(); i++)
                {
                    if (isExist(ListIDOnline, Convert.ToInt32(userArr.data[i].friend_Conversation_ID)))
                    {
                        foreach (var item in this.Controls)
                        {
                            if (item is activeFriend)
                            {
                                activeFriend aFriend = item as activeFriend;
                                if (Convert.ToInt32(aFriend.Tag) == Convert.ToInt32(userArr.data[i].friend_Conversation_ID))
                                {
                                    aFriend.UpdateFriend(userArr.data[i].friend_Username, userArr.data[i].friend_Fullname,
                            userArr.data[i].friend_lastLogin, userArr.data[i].NumOfUnSeenMessage, userArr.data[i].friend_Conversation_ID);
                                    break;
                                }
                            }

                        }

                    }

                    else
                    {

                        ListIDOnline.Add(Convert.ToInt32(userArr.data[i].friend_Conversation_ID));
                        activeFriend friend = new activeFriend(userArr.data[i].friend_Username, userArr.data[i].friend_Fullname,
                            userArr.data[i].friend_lastLogin, userArr.data[i].NumOfUnSeenMessage, userArr.data[i].friend_Conversation_ID);
                        friend.Location = new Point(10, 0);
                        friend.Top = friend_last.Bottom + 20;

                        friend.Width = this.Width - 20;
                        friend.Tag = userArr.data[i].friend_Conversation_ID.ToString();

                        friend.MouseEnter += Friend_Enter;
                        friend.Click += Friend_Click;


                        this.Controls.Add(friend);
                        //this.VerticalScroll.Value = this.VerticalScroll.Maximum;
                        //this.VerticalScroll.Visible = false;
                        friend_last = friend;
                    }
                }
            }

            if (listUsers == "[]")
            {
                label_NoActiveFriend.Visible = true;
                this.Controls.Add(label_NoActiveFriend);
            }
            
        }

        private void TimeRequest_Tick(object sender, EventArgs e)
        {
            TimeRequest.Stop();
            TimeRequest.Interval = 5000;
            GetDataAsync();
        }

        public event EventHandler FriendClicked;
        protected virtual void OnFriendClicked(object sender, EventArgs e)
        {
            var handler = FriendClicked;

            if (handler != null)
                handler(sender, e);
        }

        private void Friend_Enter(object sender, EventArgs e)
        {
            Internal_Society.activeFriend atf = sender as Internal_Society.activeFriend;
            if (atf != null && atf.BackColor != Color.FromArgb(App_Status.RedTabChat, App_Status.GreenTabChat, App_Status.BlueTabChat))
                atf.BackColor = Color.FromArgb(App_Status.backFormColor.R - 10, App_Status.backFormColor.G - 10, App_Status.backFormColor.B - 10);
        }

        private void Friend_Click(object sender, EventArgs e)
        {
            //While you can call `this.ParentForm.Close()` it's better to raise an event
            if(sender is activeFriend)
            {
                activeFriend aF = sender as activeFriend;
                isViewing = aF.ConversationID;
                aF.TurnOffNumOfMessage();
            }
            OnFriendClicked(sender, e);
        }

        private void OnlineList_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Controls.Count.ToString());
            foreach (var item in this.Controls)
            {
                Internal_Society.activeFriend atf = item as Internal_Society.activeFriend;
                if (atf != null && atf.BackColor != Color.FromArgb(App_Status.RedTabChat, App_Status.GreenTabChat, App_Status.BlueTabChat)) atf.BackColor = Color.Transparent;
            }
        }
    }

    
}