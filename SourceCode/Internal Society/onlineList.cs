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
        string listUsers = "99";
        public void ShowOnlineUser()
        {
            label1.Visible = false;
            string urlSearchUser = "https://kunbr0.com/it008/search.php?data_search=" + "toan";
            listUsers = new WebClient().DownloadString(urlSearchUser);
            if (listUsers != "")
            {
                this.Controls.Clear();
                label1.Visible = false;
                List<Friend_Info> userArr = new List<Friend_Info>();
                userArr = JsonConvert.DeserializeObject<List<Friend_Info>>(listUsers);
                if (userArr.Count() > 0)
                {
                    activeFriend friend_last = new activeFriend(userArr[0].friend_Username, userArr[0].friend_Fullname);
                    friend_last.Top = 0 - friend_last.Height + 10;
                    for (int i = 0; i < userArr.Count(); i++)
                    {
                        activeFriend friend = new activeFriend(userArr[i].friend_Username, userArr[i].friend_Fullname);
                        friend.Location = new Point(10, 0);
                        friend.Top = friend_last.Bottom + 20;
                        friend.Width = this.Width - 35;
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

    }
}
