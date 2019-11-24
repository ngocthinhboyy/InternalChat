using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class HomePage : Form
    {
        public static List<UserControl> ListPanel = new List<UserControl>();
        public static List<UserControl> ListChat = new List<UserControl>();
        
        Color activeTabChat = Color.FromArgb(123, 123, 123);
        Color inactiveTabChat = Color.Transparent;

        Internal_Society.Panel_Dashboard panel_Dashboard = new Internal_Society.Panel_Dashboard();
        //Internal_Society.Panel_Chat panel_Chat = new Internal_Society.Panel_Chat(1);
        Internal_Society.Panel_Profile panel_Profile = new Internal_Society.Panel_Profile();
        Internal_Society.Panel_Cart panel_Cart = new Internal_Society.Panel_Cart();
        Internal_Society.Panel_Calendar panel_Calendar = new Internal_Society.Panel_Calendar();
        Internal_Society.Panel_Games panel_Games = new Internal_Society.Panel_Games();
        Internal_Society.Panel_Settings panel_Settings = new Internal_Society.Panel_Settings();
        Internal_Society.Panel_Search panel_Search1 = new Internal_Society.Panel_Search();

        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label_Fullname.Text = User_Info.k_Fullname;

            panel_Dashboard.Dock = DockStyle.Fill;
            //panel_Chat.Dock = DockStyle.Fill;
            panel_Profile.Dock = DockStyle.Fill;
            panel_Cart.Dock = DockStyle.Fill;
            panel_Calendar.Dock = DockStyle.Fill;
            panel_Games.Dock = DockStyle.Fill;
            panel_Settings.Dock = DockStyle.Fill;
            panel_Search1.Dock = DockStyle.Fill;

            

            this.panel_Main.Controls.Add(panel_Dashboard);
            ListPanel.Add(panel_Dashboard);
            //this.panel_Main.Controls.Add(panel_Chat);
            //ListPanel.Add(panel_Chat);
            this.panel_Main.Controls.Add(panel_Profile);
            ListPanel.Add(panel_Profile);
            this.panel_Main.Controls.Add(panel_Cart);
            ListPanel.Add(panel_Cart);
            this.panel_Main.Controls.Add(panel_Calendar);
            ListPanel.Add(panel_Calendar);
            this.panel_Main.Controls.Add(panel_Games);
            ListPanel.Add(panel_Games);
            this.panel_Main.Controls.Add(panel_Settings);
            ListPanel.Add(panel_Settings);
            this.panel_Main.Controls.Add(panel_Search1);
            ListPanel.Add(panel_Search1);
        }

        

        private void FriendClicked(object sender, EventArgs e)
        {
            
            TurnOffPanel();
            TurnOffTabChat();
            bool isExist = false;
            
            Internal_Society.activeFriend atf = sender as Internal_Society.activeFriend;
            atf.BackColor = activeTabChat;
            for (int i = 0; i < ListChat.Count; i++)
            {
                if(ListChat[i].Tag.ToString() == atf.Tag.ToString())
                {
                    ListChat[i].Visible = true;
                    isExist = true;
                }
            }

            if (!isExist)
            {
                Internal_Society.Panel_Chat panel_Chat = new Internal_Society.Panel_Chat(Convert.ToInt32(atf.Tag));


                panel_Chat.Dock = DockStyle.Fill;
                panel_Chat.Visible = true;
                panel_Chat.Tag = atf.Tag;

                ListChat.Add(panel_Chat);
                panel_Main.Controls.Add(panel_Chat);
                
            }

            
        }

        public void Update_App_Status()
        {
            App_Status.HomePage_Left = this.Left;
            App_Status.HomePage_Top = this.Top;
            App_Status.HomePage_Width = this.Width;
            App_Status.HomePage_Height = this.Height;
        }


        void TurnOffPanel()
        {
            foreach(var pnl in ListPanel)
            {
                pnl.Visible = false;
            }

            foreach (var pnl in ListChat)
            {
                pnl.Visible = false;
                
            }
        }

        
        void TurnOffTabChat()
        {
            foreach(var tabchat in onlineList1.Controls)
            {
                Internal_Society.activeFriend atf = tabchat as Internal_Society.activeFriend;
                atf.BackColor = inactiveTabChat;
            }
        }

        void MoveIndicator(Control control)
        {
            indicator.Top = control.Top;
            indicator.Height = control.Height;
        }

        private void Tab_DashBoard_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Dashboard.Visible = true;
            App_Status.time_delay = 10000;
        }

        private void Tab_Profile_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Profile.Visible = true;
            App_Status.time_delay = 10000;
        }

        private void Tab_Chat_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            
            App_Status.time_delay = 1500;
            Tab_Calendar.Visible = false;
            Tab_Cart.Visible = false;
            Tab_Chat.Visible = false;
            Tab_DashBoard.Visible = false;
            Tab_Games.Visible = false;
            Tab_Profile.Visible = false;
            Tab_Settings.Visible = false;
            indicator.Visible = false;
            onlineList1.Visible = true;
            onlineList1.Dock = DockStyle.Left;
            btn_create_new.Text = "Back to menu";
            onlineList1.ShowOnlineUser();
        }

        private void Tab_Cart_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Cart.Visible = true;
            App_Status.time_delay = 10000;
        }

        private void Tab_Calendar_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Calendar.Visible = true;
            App_Status.time_delay = 10000;
        }

        private void Tab_Games_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Games.Visible = true;
            App_Status.time_delay = 10000;
        }

        private void Tab_Settings_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Settings.Visible = true;
            App_Status.time_delay = 10000;
        }

        private void HomePage_Resize(object sender, EventArgs e)
        {
            Update_App_Status();
        }

        private void HomePage_Move(object sender, EventArgs e)
        {
            Update_App_Status();

        }

        private void Textbox_Search_Enter(object sender, EventArgs e)
        {
            textbox_Search.text = "";

            //panel_Search1.Visible = true;
        }

        private void Textbox_Search_Leave(object sender, EventArgs e)
        {
            textbox_Search.text = "Search...";
        }
        public static string searchInfo = "";
        string searchInfoLast = "";
        private void Textbox_Search_KeyUp(object sender, EventArgs e)
        {
            panel_Search1.Visible = true;
            searchInfo = textbox_Search.text;
            // searchInfo = "" thì tất cả các userInfo hiện trên panel_Search sẽ bị clear hết
            if (searchInfo == "")
                panel_Search1.Controls.Clear();
            else
            // Mỗi khi sự kiện keyup xảy ra phải kiểm tra xem  username nhập vô khác với username trước đó không
            // Nếu khác phải clear kết quả cũ, hiển thị một list các kết quả mới.
            if (searchInfo != searchInfoLast)
            {
                //panel_Search1.Controls.Clear();
                panel_Search1.AddFriendInfo();
                searchInfoLast = searchInfo;
            }
        }

        private void Picture_user_image_Click(object sender, EventArgs e)
        {

        }

        private void Textbox_Search_Click(object sender, EventArgs e)
        {
            /*textbox_Search.text = "";
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Search1.Visible = true;*/
        }

        private void Btn_create_new_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)Tab_DashBoard);
            TurnOffPanel();
            onlineList1.Visible = false;
            panel_Dashboard.Visible = true;
            Tab_Calendar.Visible = true;
            Tab_Cart.Visible = true;
            Tab_Chat.Visible = true;
            Tab_DashBoard.Visible = true;
            Tab_Games.Visible = true;
            Tab_Profile.Visible = true;
            Tab_Settings.Visible = true;
            indicator.Visible = true;
        }













        // Function Profile CLick




    }
}
