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
        private static int MarginBottomOfFriend = 20;
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
            List<int> ProcessedFriend = new List<int>();

            if (listUsers == "") return;
            ListUserOnline userArr = new JavaScriptSerializer().Deserialize<ListUserOnline>(listUsers);


            if (!userArr.success)
            {
                this.Controls.Clear();
                this.Controls.Add(label_NoActiveFriend);
                CopyListToList(ProcessedFriend, ListIDOnline);
                label_NoActiveFriend.Visible = true;
                return;
            }


            if (userArr.data.Count() > 0)
            {
                activeFriend friend_last = new activeFriend("", "", "",
                    0, 0, 0, 0);

                friend_last.Top = 0 - friend_last.Height + 10;
                foreach (Control kk in this.Controls)
                {
                    if (kk is activeFriend)
                    {
                        activeFriend aF = kk as activeFriend;
                        friend_last = aF;
                    }
                }
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
                                    aFriend.UpdateFriend(userArr.data[i].friend_Avatar, userArr.data[i].friend_Username, userArr.data[i].friend_Fullname,
                            userArr.data[i].friend_lastLogin, userArr.data[i].NumOfUnSeenMessage, userArr.data[i].friend_Conversation_ID);
                                    ProcessedFriend.Add(userArr.data[i].friend_Conversation_ID);

                                    break;

                                }
                            }

                        }

                    }

                    else
                    {

                        ListIDOnline.Add(Convert.ToInt32(userArr.data[i].friend_Conversation_ID));
                        activeFriend friend = new activeFriend(userArr.data[i].friend_Avatar, userArr.data[i].friend_Username, userArr.data[i].friend_Fullname,
                            userArr.data[i].friend_lastLogin, userArr.data[i].NumOfUnSeenMessage, userArr.data[i].friend_Conversation_ID, userArr.data[i].ColorID);
                        friend.Location = new Point(10, 0);
                        friend.Top = friend_last.Bottom + MarginBottomOfFriend;

                        friend.Width = this.Width - MarginBottomOfFriend;
                        friend.Tag = userArr.data[i].friend_Conversation_ID.ToString();

                        friend.MouseEnter += Friend_Enter;
                        friend.Click += Friend_Click;


                        this.Controls.Add(friend);
                        //this.VerticalScroll.Value = this.VerticalScroll.Maximum;
                        //this.VerticalScroll.Visible = false;
                        friend_last = friend;
                        ProcessedFriend.Add(userArr.data[i].friend_Conversation_ID);
                    }
                }


            }

            for (int i = 0; i < ListIDOnline.Count; i++)
            {
                if (!isExist(ProcessedFriend, ListIDOnline[i]))
                {
                    RemoveFriendFromUserID(ListIDOnline[i]);
                    //MessageBox.Show("remove");
                }
            }


            CopyListToList(ProcessedFriend, ListIDOnline);
        }

        private void CopyListToList(List<int> From, List<int> To)
        {
            To.Clear();
            foreach (int item in From)
            {
                To.Add(item);
            }
        }

        private void RemoveFriendFromUserID(int a)
        {
            int kIndex = 0;

            foreach (var item in this.Controls)
            {
                if (item is activeFriend)
                {

                    activeFriend aFriend = item as activeFriend;
                    if (Convert.ToInt32(aFriend.Tag) == a)
                    {
                        this.Controls.Remove(aFriend);
                        kIndex++;
                        break;
                    }
                }

            }
            for (int i = kIndex; i < this.Controls.Count; i++)
            {
                activeFriend aF = this.Controls[i] as activeFriend;
                aF.Top -= (aF.Height + MarginBottomOfFriend);
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
            if (sender is activeFriend)
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
                if (atf != null && atf.BackColor != Color.FromArgb(App_Status.backFormColor.R, App_Status.backFormColor.G, App_Status.backFormColor.B)) atf.BackColor = Color.Transparent;
            }
        }
    }


}