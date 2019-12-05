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
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class HomePage : Form
    {
        public static List<UserControl> ListPanel = new List<UserControl>();
        public static List<UserControl> ListChat = new List<UserControl>();
        
        Color activeTabChat = Color.FromArgb(App_Status.RedTabChat, App_Status.GreenTabChat, App_Status.BlueTabChat);
        Color inactiveTabChat = Color.Transparent;

        Internal_Society.Panel_Dashboard panel_Dashboard = new Internal_Society.Panel_Dashboard();
        //Internal_Society.Panel_Chat panel_Chat = new Internal_Society.Panel_Chat(1);
        Internal_Society.Panel_Profile panel_Profile = new Internal_Society.Panel_Profile();
        Internal_Society.Panel_Cart panel_Cart = new Internal_Society.Panel_Cart();
        Internal_Society.Panel_Notification panel_Calendar = new Internal_Society.Panel_Notification();
        Internal_Society.Panel_Games panel_Games = new Internal_Society.Panel_Games();
        //Internal_Society.Panel_Settings panel_Settings = new Internal_Society.Panel_Settings();
        Internal_Society.Panel_Search panel_Search1 = new Internal_Society.Panel_Search();

        public HomePage()
        {
            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeHomePage = new Panel_Controls.DarkMode(this.ChangeDarkMode);
            this.StartPosition = FormStartPosition.CenterScreen;
            label_Fullname.Text = User_Info.k_Fullname;

            panel_Dashboard.Dock = DockStyle.Fill;
            //panel_Chat.Dock = DockStyle.Fill;
            panel_Profile.Dock = DockStyle.Fill;
            panel_Cart.Dock = DockStyle.Fill;
            panel_Calendar.Dock = DockStyle.Fill;
            panel_Games.Dock = DockStyle.Fill;
          //  panel_Settings.Dock = DockStyle.Fill;
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
            this.panel_Main.Controls.Add(panel_Search1);
            ListPanel.Add(panel_Search1);
            this.onlineList1.FriendClicked += FriendClicked;

            ListSticker.getSticker();
        }
        public void ChangeDarkMode()
        {
            // Change background color of panels and tabs
            panel1.BackColor = panel2.BackColor = pn_header.BackColor = textbox_Search.FillColor =
           Tab_Cart.BackColor = Tab_Chat.BackColor = Tab_DashBoard.BackColor = Tab_Games.BackColor
           = Tab_Notification.BackColor = Tab_Profile.BackColor = onlineList1.BackColor = App_Status.backFormColor;

            Tab_Cart.Activecolor = Tab_Chat.Activecolor = Tab_DashBoard.Activecolor = Tab_Games.Activecolor
            = Tab_Notification.Activecolor = Tab_Profile.Activecolor = App_Status.backFormColor;

            Tab_Cart.OnHovercolor = Tab_Chat.OnHovercolor = Tab_DashBoard.OnHovercolor = Tab_Games.OnHovercolor
            = Tab_Notification.OnHovercolor = Tab_Profile.OnHovercolor = App_Status.backFormColor;

            Tab_Cart.Normalcolor = Tab_Chat.Normalcolor = Tab_DashBoard.Normalcolor = Tab_Games.Normalcolor
            = Tab_Notification.Normalcolor = Tab_Profile.Normalcolor = App_Status.backFormColor;
            //Change font color
            Tab_Cart.Textcolor = Tab_Chat.Textcolor = Tab_DashBoard.Textcolor = Tab_Games.Textcolor
            = Tab_Notification.Textcolor = Tab_Profile.Textcolor = textbox_Search.ForeColor =
            textbox_Search.BorderColorIdle = textbox_Search.BorderColorHover = textbox_Search.BorderColorActive =
            textbox_Search.BorderColorDisabled = App_Status.textColor;
            //Change color of icon
            Tab_DashBoard.Iconimage = Image.FromFile(App_Status.iconDashboard);
            Tab_Cart.Iconimage = Image.FromFile(App_Status.iconCart);
            Tab_Profile.Iconimage = Image.FromFile(App_Status.iconProfile);
            Tab_Games.Iconimage = Image.FromFile(App_Status.iconGames);
            Tab_Notification.Iconimage = Image.FromFile(App_Status.iconNoti);
            Tab_Chat.Iconimage = Image.FromFile(App_Status.iconChat);
            //Change panel background
            panel_Main.BackColor = App_Status.backPanelColor;
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
                if(tabchat is activeFriend)
                {
                    Internal_Society.activeFriend atf = tabchat as Internal_Society.activeFriend;
                    atf.BackColor = inactiveTabChat;
                }
                
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
            Tab_Notification.Visible = false;
            Tab_Cart.Visible = false;
            Tab_Chat.Visible = false;
            Tab_DashBoard.Visible = false;
            Tab_Games.Visible = false;
            Tab_Profile.Visible = false;
           // Tab_Settings.Visible = false;
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

        private void Tab_Notification_Click(object sender, EventArgs e)
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

        private void HomePage_Resize(object sender, EventArgs e)
        {
            Update_App_Status();
        }

        private void HomePage_Move(object sender, EventArgs e)
        {
            Update_App_Status();

        }

        
        public static string searchInfo = "";
        string searchInfoLast = "";
       
        private void Picture_user_image_Click(object sender, EventArgs e)
        {

        }


        private void Btn_create_new_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)Tab_DashBoard);
            TurnOffPanel();
            onlineList1.Visible = false;
            panel_Dashboard.Visible = true;
            Tab_Notification.Visible = true;
            Tab_Cart.Visible = true;
            Tab_Chat.Visible = true;
            Tab_DashBoard.Visible = true;
            Tab_Games.Visible = true;
            Tab_Profile.Visible = true;
           // Tab_Settings.Visible = true;
            indicator.Visible = true;
        }

        private void Textbox_Search_Leave_1(object sender, EventArgs e)
        {
            textbox_Search.Text = "Search...";
        }

        private void Textbox_Search_KeyUp(object sender, KeyEventArgs e)
        {
            TurnOffPanel();
            panel_Search1.Visible = true;
            searchInfo = textbox_Search.Text;
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

        private void Textbox_Search_Enter_1(object sender, EventArgs e)
        {
            textbox_Search.Text = "";
        }






        





        // Function Profile CLick




    }
}
