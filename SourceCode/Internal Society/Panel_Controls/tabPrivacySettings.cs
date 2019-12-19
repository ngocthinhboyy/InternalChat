using System;
using System.Drawing;
using System.Windows.Forms;

namespace Internal_Society.Panel_Controls
{
    public delegate void DarkMode();
    public partial class tabPrivacySettings : UserControl
    {
        public static DarkMode delegateChangeHomePage;
        public static DarkMode delegateChangeProfile;
        public static DarkMode delegateChangePrivacySettings;
        public static DarkMode delegateChangeProfileInfo;
        public static DarkMode delegateChangeCart;
        public static DarkMode delegateChangeGames;
        public static DarkMode delegateChangeSearch;
        public static DarkMode delegateChangeDashboard;
        public static bool activeStatus = true;

        public tabPrivacySettings()
        {
            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangePrivacySettings = new Panel_Controls.DarkMode(this.ChangeDarkMode);
            if (User_Info.k_SearchAvailable)
            {
                searchMe_AllPeople.Checked = true;
            }
            else
            {
                searchMe_OnlyMe.Checked = true;
            }
            if (User_Info.k_SeeProfileAvailable)
            {
                seeProfile_Public.Checked = true;
            }
            else
            {
                seeProfile_OnlyMe.Checked = true;
            }
            if (User_Info.k_DarkMode)
            {
                //DarkModeSwitch.Value = true;
            }
            else
            {
                //DarkModeSwitch.Value = false;
            }


        }
        public void ChangeDarkMode()
        {
            label1.ForeColor = label2.ForeColor = label4.ForeColor =
            label5.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor = label11.ForeColor =
            label10.ForeColor = label9.ForeColor = App_Status.textColor;
        }
        private void DarkModeSwitch_OnValuechange(object sender, EventArgs e)
        {
            if (DarkModeSwitch.Value == true)
            {
                App_Status.backFormColor = Color.FromArgb(42, 42, 49);
                App_Status.backPanelColor = Color.FromArgb(42, 42, 49);
                App_Status.textColor = Color.White;
                App_Status.iconDashboard = App_Status.urlLocalResources + "material-icons_3-0-1_dashboard_35_0_ffffff_none.png";
                App_Status.iconCart = App_Status.urlLocalResources + "font-awesome_4-7-0_shopping-cart_35_0_ffffff_none.png";
                App_Status.iconChat = App_Status.urlLocalResources + "ionicons_2-0-1_chatbox-working_35_0_ffffff_none.png";
                App_Status.iconProfile = App_Status.urlLocalResources + "icomoon-free_2014-12-23_profile_35_0_ffffff_none.png";
                App_Status.iconGames = App_Status.urlLocalResources + "font-awesome_4-7-0_gamepad_35_0_ffffff_none.png";
                App_Status.iconNoti = App_Status.urlLocalResources + "ionicons_2-0-1_android-notifications_35_0_ffffff_none.png";
                App_Status.logo = App_Status.urlLocalResources + "IC.html (2)-page-001.jpg";
                /*User_Info.k_DarkMode = true;
                User_Info.UpdateUserInfo();*/
            }
            else
            {
                App_Status.backFormColor = Color.White;
                App_Status.backPanelColor = Color.White;
                App_Status.textColor = Color.FromArgb(42, 42, 49);
                App_Status.iconDashboard = App_Status.urlLocalResources + "material-icons_3-0-1_dashboard_35_0_000000_none.png";
                App_Status.iconCart = App_Status.urlLocalResources + "font-awesome_4-7-0_shopping-cart_35_0_000000_none.png";
                App_Status.iconChat = App_Status.urlLocalResources + "ionicons_2-0-1_chatbox-working_35_0_000000_none.png";
                App_Status.iconProfile = App_Status.urlLocalResources + "icomoon-free_2014-12-23_profile_35_0_000000_none.png";
                App_Status.iconGames = App_Status.urlLocalResources + "font-awesome_4-7-0_gamepad_35_0_000000_none.png";
                App_Status.iconNoti = App_Status.urlLocalResources + "ionicons_2-0-1_android-notifications_35_0_000000_none.png";
                App_Status.logo = App_Status.urlLocalResources + "IC.html-page-001.jpg";
            }
            delegateChangeHomePage();
            delegateChangeProfile();
            delegateChangePrivacySettings();
            delegateChangeProfileInfo();
            delegateChangeCart();
            delegateChangeSearch();
            delegateChangeGames();
            delegateChangeDashboard();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LogOutConfirmation logOutConfirmation = new LogOutConfirmation();
            logOutConfirmation.StartPosition = FormStartPosition.CenterScreen;
            logOutConfirmation.Show();

        }

        private void ActiveStatusSwitch_OnValuechange(object sender, EventArgs e)
        {
            if (ActiveStatusSwitch.Value == true)
            {
                activeStatus = true;
            }
            else
            {
                activeStatus = false;
            }
        }

        private void SearchMe_AllPeople_Click(object sender, EventArgs e)
        {
            User_Info.k_SearchAvailable = true;
            User_Info.UpdateUserInfo();
        }

        private void SearchMe_OnlyFriend_Click(object sender, EventArgs e)
        {
            User_Info.k_SearchAvailable = false;
            User_Info.UpdateUserInfo();
        }

        private void SearchMe_OnlyMe_Click(object sender, EventArgs e)
        {
            User_Info.k_SearchAvailable = false;
            User_Info.UpdateUserInfo();
        }

        private void SeeProfile_Public_Click(object sender, EventArgs e)
        {
            User_Info.k_SeeProfileAvailable = true;
            User_Info.UpdateUserInfo();
        }

        private void SeeProfile_Friends_Click(object sender, EventArgs e)
        {
            User_Info.k_SeeProfileAvailable = false;
            User_Info.UpdateUserInfo();
        }

        private void SeeProfile_OnlyMe_Click(object sender, EventArgs e)
        {
            User_Info.k_SeeProfileAvailable = false;
            User_Info.UpdateUserInfo();
        }
    }
}
