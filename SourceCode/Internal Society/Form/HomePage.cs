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
        public static string searchInfo = "";

        Color activeTabChat = Color.FromArgb(App_Status.RedTabChat, App_Status.GreenTabChat, App_Status.BlueTabChat);
        Color inactiveTabChat = Color.Transparent;
        Internal_Society.Panel_Dashboard panel_Dashboard = new Internal_Society.Panel_Dashboard();
        Internal_Society.Panel_Profile panel_Profile = new Internal_Society.Panel_Profile();
        Internal_Society.Panel_Cart panel_Cart = new Internal_Society.Panel_Cart();
        Internal_Society.Panel_Notification panel_Calendar = new Internal_Society.Panel_Notification();
        Internal_Society.Panel_Games panel_Games = new Internal_Society.Panel_Games();
        Internal_Society.Panel_Search panel_Search1 = new Internal_Society.Panel_Search();
        public static bool isClickedNotiTab = false;
        public static bool isClickedChatTab = false;
        public HomePage()
        {
            InitializeComponent();
            //MessageBox.Show(App_Status.notification.ToString());
            LoginForm.isClick = false;
            Internal_Society.Panel_Controls.tabProfileInfo.delegateChangeAva = new Panel_Controls.ChangeAva(this.ChangeAva);

            LogOutConfirmation.delegateCloseHomePage = new CloseHomePage(this.closeHomePage);
            Internal_Society.Panel_Notification.delegateNoti = new Notification(this.Noti);
            //Internal_Society.chatbox.delegateMessage = new CompletedGetMessage(this.MessageNoti);
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
            //MessageBox.Show(App_Status.notification.ToString());
            if (User_Info.k_Avatar == "")
            {
                picture_user_image.ImageLocation = App_Status.urlLocalResources + "user_001.png";
            }
            else
            {
                picture_user_image.ImageLocation = App_Status.urlImage + "/image/" + User_Info.k_Avatar;
            }
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
        public async void ChangeAva()
        {

            picture_user_image.ImageLocation = User_Info.localAvatar;
        }
        public void closeHomePage()
        {
            this.Close();
        }
        //public void MessageNoti()
        //{
        //    if (App_Status.message > 0)
        //    {
        //        lbl_MessageNoti.Visible = true;
        //        lbl_MessageNoti.Text = App_Status.message.ToString();
        //        pictureBox1.Visible = true;
        //        isClickedChatTab = false;
        //    }
        //    else
        //    {
        //        pictureBox1.Visible = false;
        //        lbl_MessageNoti.Visible = false;
        //    }
        //}
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
            textbox_Search.BorderColorDisabled = label_Fullname.ForeColor = App_Status.textColor;
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
        public void Noti()
        {
            if (App_Status.notification > 0)
            {
                lbl_Noti.Visible = true;
                lbl_Noti.Text = App_Status.notification.ToString();
                pictureBox2.Visible = true;
                isClickedNotiTab = false;
            }
            else
            {
                pictureBox2.Visible = false;
                lbl_Noti.Visible = false;
            }
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
                    //ListChat[i].Visible = true;
                    bunifuTransition6.ShowSync(ListChat[i]);
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                Internal_Society.Panel_Chat panel_Chat = new Internal_Society.Panel_Chat(Convert.ToInt32(atf.Tag));


                panel_Chat.Dock = DockStyle.Fill;
                //panel_Chat.Visible = true;
                bunifuTransition6.ShowSync(panel_Chat);
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
                //pnl.Visible = false;
                if( pnl is Panel_Chat)
                bunifuTransition6.HideSync(pnl);
                else pnl.Visible = false;
            }

            foreach (var pnl in ListChat)
            {
                //pnl.Visible = false;
                if (pnl is Panel_Chat)
                    bunifuTransition6.HideSync(pnl);
                else pnl.Visible = false;


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
            bunifuTransition1.ShowSync(panel_Dashboard);
            //panel_Dashboard.Visible = true;
            App_Status.time_delay = 10000;
            if (isClickedNotiTab == false)
            {
                Noti();
            }
        }
        private void Tab_Profile_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            bunifuTransition2.ShowSync(panel_Profile);
            //panel_Profile.Visible = true;
            App_Status.time_delay = 10000;
            if (isClickedNotiTab == false)
            {
                Noti();
            }


        }
        private void Tab_Chat_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            lbl_Noti.Visible = false;
            pictureBox2.Visible = false;
            App_Status.time_delay = 1500;
            Tab_Notification.Visible = false;
            Tab_Cart.Visible = false;
            Tab_Chat.Visible = false;
            Tab_DashBoard.Visible = false;
            Tab_Games.Visible = false;
            Tab_Profile.Visible = false;
            // Tab_Settings.Visible = false;
            indicator.Visible = false;
            onlineList1.Show();
            onlineList1.Dock = DockStyle.Left;
            //btn_create_new.Text = "Back to menu";
            onlineList1.ShowOnlineUser();
            btnBack.Visible = true;
            //btn_create_new.Visible = false;
        }
        private void Tab_Cart_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            bunifuTransition3.ShowSync(panel_Cart);
            //panel_Cart.Visible = true;
            App_Status.time_delay = 10000;
            if(isClickedNotiTab == false)
            {
                Noti();
            }

        }
        private void Tab_Notification_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            bunifuTransition4.ShowSync(panel_Calendar);
            //panel_Calendar.Visible = true;
            App_Status.time_delay = 10000;
            isClickedNotiTab = true;
            App_Status.notification = 0;
            string urlRequest = App_Status.urlAPI + "c_User/Edit/" + User_Info.k_ID + "/lastNotification/" + Panel_Notification.lastNoti;
            //MessageBox.Show(urlRequest);
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            Noti();
        }
        private void Tab_Games_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            bunifuTransition5.ShowSync(panel_Games);
            //panel_Games.Visible = true;
            App_Status.time_delay = 10000;
            if (isClickedNotiTab == false)
            {
                Noti();
            }
        }
        private void HomePage_Resize(object sender, EventArgs e)
        {
            Update_App_Status();
        }
        private void HomePage_Move(object sender, EventArgs e)
        {
            Update_App_Status();

        }
        private void Picture_user_image_Click(object sender, EventArgs e)
        {

        }
        private void Btn_create_new_Click(object sender, EventArgs e)
        {
            
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
                panel_Search1.LabelHuongDanSuDung();
            else

            {
                //panel_Search1.Controls.Clear();
                panel_Search1.AddFriendInfo();

            }
        }
        private void Textbox_Search_Enter_1(object sender, EventArgs e)
        {
            textbox_Search.Text = "";
        }
        private void BtnBack_Click(object sender, EventArgs e)
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
            indicator.Visible = true;
            btnBack.Visible = false;
            //btn_create_new.Visible = true;
        }

    }
}
