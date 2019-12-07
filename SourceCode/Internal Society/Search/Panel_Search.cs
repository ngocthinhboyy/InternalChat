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
        public Panel_Search()
        {
            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeSearch = new Panel_Controls.DarkMode(this.ChangeDarkMode);
        }
        public void ChangeDarkMode()
        {
            this.BackColor = App_Status.backFormColor;
        }

        public async void SearchUserAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "/c_User/Search/" + HomePage.searchInfo + "/" + page;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;

            ProccessData(result);
        }

        
        public void AddFriendInfo()
        {   // list dùng để lưu kết quả ứng với username mà người dùng search
            label_Error.Visible = false;
            string urlSearchUser = App_Status.urlAPI + "/c_User/Search/" + HomePage.searchInfo + "/" + page;

            SearchUserAsync();
        }

        private void ProccessData(string listUsers)
        {
            ListSearchUser dSearchUser = new JavaScriptSerializer().Deserialize<ListSearchUser>(listUsers);
            this.Controls.Clear();
            //listUser không rỗng, nghĩa là tồn tại những user có username trùng với tên người dùng nhập
            //thì sẽ chuyển chuỗi đó thành các đối tượng thuộc list
            if (dSearchUser.success)
            {
                
                
                label_Error.Visible = false;
                
                

                if (dSearchUser.data.Count() > 0)
                {
                    // hiển thị các user trùng với username người dùng nhập
                    friendInfo friend_last = new friendInfo(dSearchUser.data[0].username, dSearchUser.data[0].fullname,
                        Convert.ToInt32(dSearchUser.data[0].user_id));
                    friend_last.Top = 0 - friend_last.Height + 10;
                    for (int i = 0; i < dSearchUser.data.Count(); i++)
                    {
                        friendInfo friend = new friendInfo(dSearchUser.data[i].username, dSearchUser.data[i].fullname,
                        Convert.ToInt32(dSearchUser.data[i].user_id));
                        //friend.Location = new Point(this.Width - friend.Width - 70, 0);
                        friend.Location = new Point(70, 0);
                        friend.Anchor = AnchorStyles.Top;
                        friend.Top = friend_last.Bottom + 20;
                        this.Controls.Add(friend);

                        this.VerticalScroll.Value = this.VerticalScroll.Maximum;
                        friend_last = friend;
                    }
                }


            }
            else
            {
                label_Error.Visible = true;
                this.Controls.Add(label_Error);
            }
        }
    }
}
