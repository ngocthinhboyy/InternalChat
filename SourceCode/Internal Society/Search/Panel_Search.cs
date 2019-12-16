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
using Newtonsoft.Json;
using System.Threading;
using System.Web.Script.Serialization;

namespace Internal_Society
{
    public partial class Panel_Search : UserControl
    {
        int page = 0;
        List<int> ListUserID;
        public Panel_Search()
        {
            InitializeComponent();
            ListUserID = new List<int>();
            panel_Main.Controls.Clear();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeSearch = new Panel_Controls.DarkMode(this.ChangeDarkMode);
        }
        public void ChangeDarkMode()
        {
            this.BackColor = App_Status.backFormColor;
        }



        public async void SearchUserAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "/c_User/Search/" + User_Info.k_ID + "/" + HomePage.searchInfo + "/" + page;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;

            ProccessData(result);
        }

        public void LabelHuongDanSuDung()
        {
            label_Message.Text = "Please input some character to search !";
            panel_Main.Visible = false;
            label_Message.Visible = true;
        }

        public void ErrorNonUser()
        {
            label_Message.Text = "We could not find anything that matches your search.";
            panel_Main.Visible = false;
            label_Message.Visible = true;
        }

        public void AddFriendInfo()
        {   // list dùng để lưu kết quả ứng với username mà người dùng search
            label_Message.Visible = false;
            SearchUserAsync();
        }

        private bool IsExistInList(List<int> kList, int a)
        {
            foreach (int item in kList)
            {
                if (item == a) return true;
            }
            return false;
        }

        private void ProccessData(string listUsers)
        {

            ListSearchUser dSearchUser = new JavaScriptSerializer().Deserialize<ListSearchUser>(listUsers);

            if (dSearchUser.success)
            {
                panel_Main.Visible = true;
                friendInfo friend_last = new friendInfo();
                friend_last.Height = 2;

                foreach (Control item in panel_Main.Controls)
                {
                    if (item is friendInfo)
                    {
                        friendInfo fI = item as friendInfo;
                        friend_last = fI;
                    }

                }

                int CountExist = 0;
                for (int i = 0; i < dSearchUser.data.Count(); i++)
                {
                    if (IsExistInList(ListUserID, dSearchUser.data[i].user_id)) CountExist++;
                }

                if (CountExist == ListUserID.Count && dSearchUser.data.Count() == ListUserID.Count)
                {
                    foreach (Control item in panel_Main.Controls)
                    {
                        if (item is friendInfo)
                        {
                            friendInfo fI = item as friendInfo;
                            int fIId = fI.FriendID;
                            for (int i = 0; i < dSearchUser.data.Count(); i++)
                            {
                                if (dSearchUser.data[i].user_id == fIId)
                                {
                                    fI.UpdateUserInfo(dSearchUser.data[i].username, dSearchUser.data[i].fullname,
                            dSearchUser.data[i].user_id, dSearchUser.data[i].isFriend);
                                    break;
                                }
                            }
                        }
                        return;
                    }
                }
                else if (dSearchUser.data.Count() > ListUserID.Count)
                {
                    for (int i = 0; i < dSearchUser.data.Count(); i++)
                    {
                        if (!IsExistInList(ListUserID, dSearchUser.data[i].user_id) && dSearchUser.data[i].user_id != Convert.ToInt32(User_Info.k_ID))
                        {
                            ListUserID.Add(dSearchUser.data[i].user_id);
                            friendInfo friend = new friendInfo(dSearchUser.data[i].username, dSearchUser.data[i].fullname,
                            dSearchUser.data[i].user_id, dSearchUser.data[i].isFriend);
                            friend.Left = (this.Width - friend.Width) / 2;
                            friend.Top = friend_last.Bottom + 20;
                            panel_Main.Controls.Add(friend);
                            this.VerticalScroll.Value = this.VerticalScroll.Maximum;
                            friend_last = friend;

                        }
                    }
                }
                else if (dSearchUser.data.Count() < ListUserID.Count)
                {


                    for (int i = 0; i < (ListUserID.Count - dSearchUser.data.Count()); i++)
                    {
                        panel_Main.Controls.RemoveAt(panel_Main.Controls.Count - 1);
                    }

                    ListUserID.Clear();

                    for (int i = 0; i < dSearchUser.data.Count(); i++)
                    {
                        if (dSearchUser.data[i].user_id != Convert.ToInt32(User_Info.k_ID))
                        {
                            friendInfo fI = panel_Main.Controls[i] as friendInfo;
                            fI.UpdateUserInfo(dSearchUser.data[i].username, dSearchUser.data[i].fullname,
                                        dSearchUser.data[i].user_id, dSearchUser.data[i].isFriend);
                            ListUserID.Add(dSearchUser.data[i].user_id);
                        }
                    }
                }
                else
                {

                    // List >< lay moi lap vao cu

                    // index cua data moi
                    List<int> kNewData = new List<int>();

                    // id cua nhung user da co trong List
                    List<int> kExistData = new List<int>();
                    for (int i = 0; i < dSearchUser.data.Count(); i++)
                    {
                        // Danh sach nhung user moi
                        if (dSearchUser.data[i].user_id != Convert.ToInt32(User_Info.k_ID))
                        {
                            if (!IsExistInList(ListUserID, dSearchUser.data[i].user_id))
                                kNewData.Add(i);
                            else kExistData.Add(dSearchUser.data[i].user_id);
                        }
                    }

                    if ((kExistData.Count + kNewData.Count) == ListUserID.Count)
                    {
                        foreach (Control item in panel_Main.Controls)
                        {
                            if (item is friendInfo)
                            {
                                friendInfo fI = item as friendInfo;
                                if (!IsExistInList(kExistData, fI.FriendID))
                                {
                                    if (kNewData.Count > 0)
                                    {
                                        fI.UpdateUserInfo(dSearchUser.data[kNewData[0]].username, dSearchUser.data[kNewData[0]].fullname,
                                    dSearchUser.data[kNewData[0]].user_id, dSearchUser.data[kNewData[0]].isFriend);
                                        kNewData.RemoveAt(0);
                                    }

                                }
                            }
                        }
                    }

                }
            }
            else
            {
                ErrorNonUser();
            }
        }

        private void Panel_Search_Resize(object sender, EventArgs e)
        {
            foreach (var item in panel_Main.Controls)
            {
                if (item is friendInfo)
                {
                    friendInfo fI = item as friendInfo;
                    fI.Left = (this.Width - fI.Width) / 2;
                }
            }
        }

        private void Panel_Main_Click(object sender, EventArgs e)
        {
            string kk = "";
            foreach (Control item in panel_Main.Controls)
            {
                if (item is friendInfo)
                {
                    friendInfo fI = item as friendInfo;
                    kk += (fI.FriendID.ToString() + " - ");
                }
            }
            MessageBox.Show(kk);
        }
    }
}
