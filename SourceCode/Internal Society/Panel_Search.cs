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

namespace Internal_Society
{
    public partial class Panel_Search : UserControl
    {
        public Panel_Search()
        {
            InitializeComponent();
            
        }

        string listUsers = "99";
        public void AddFriendInfo()
        {   // list dùng để lưu kết quả ứng với username mà người dùng search
            label_Error.Visible = false;
            string urlSearchUser = "https://kunbr0.com/it008/search.php?data_search=" + HomePage.searchInfo;

            Thread t = new Thread(() =>
            {
                listUsers = new WebClient().DownloadString(urlSearchUser);
            });
            t.Start();
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            //listUser không rỗng, nghĩa là tồn tại những user có username trùng với tên người dùng nhập
            //thì sẽ chuyển chuỗi đó thành các đối tượng thuộc list
            if (listUsers != "99")
            {
                timer1.Stop();
                this.Controls.Clear();
                label_Error.Visible = false;
                List<Friend_Info> userArr = new List<Friend_Info>();
                userArr = JsonConvert.DeserializeObject<List<Friend_Info>>(listUsers);


                if (userArr.Count() > 0)
                {
                    // hiển thị các user trùng với username người dùng nhập
                    friendInfo friend_last = new friendInfo(userArr[0].friend_Username, userArr[0].friend_Fullname);
                    friend_last.Top = 0 - friend_last.Height + 10;
                    for (int i = 0; i < userArr.Count(); i++)
                    {
                        friendInfo friend = new friendInfo(userArr[i].friend_Username, userArr[i].friend_Fullname);
                        friend.Location = new Point(100, 0);
                        friend.Top = friend_last.Bottom + 20;
                        this.Controls.Add(friend);
                        this.VerticalScroll.Value = this.VerticalScroll.Maximum;
                        friend_last = friend;
                    }
                }
                
                if(listUsers == "[]")
                {
                    label_Error.Visible = true;
                    this.Controls.Add(label_Error);
                }
                listUsers = "99";
            }
        }
    }
}
