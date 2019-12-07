using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public tabPrivacySettings()
        {
            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangePrivacySettings = new Panel_Controls.DarkMode(this.ChangeDarkMode);

        }
        public void ChangeDarkMode()
        {
            label1.ForeColor = label2.ForeColor = label4.ForeColor =
            label5.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor = label9.ForeColor =
            label10.ForeColor = label11.ForeColor = App_Status.textColor;
        }
        private void DarkModeSwitch_OnValuechange(object sender, EventArgs e)
        {
            if (DarkModeSwitch.Value == true)
            {
                App_Status.backFormColor = Color.FromArgb(42, 42, 49);
                App_Status.backPanelColor = Color.FromArgb(42, 42, 49);
                App_Status.textColor = Color.White;
                App_Status.iconDashboard = "../../Resources/material-icons_3-0-1_dashboard_35_0_ffffff_none.png";
                App_Status.iconCart = "../../Resources/font-awesome_4-7-0_shopping-cart_35_0_ffffff_none.png";
                App_Status.iconChat = "../../Resources/ionicons_2-0-1_chatbox-working_35_0_ffffff_none.png";
                App_Status.iconProfile = "../../Resources/icomoon-free_2014-12-23_profile_35_0_ffffff_none.png";
                App_Status.iconGames = "../../Resources/font-awesome_4-7-0_gamepad_35_0_ffffff_none.png";
                App_Status.iconNoti = "../../Resources/ionicons_2-0-1_android-notifications_35_0_ffffff_none.png";
            }
            else
            {
                App_Status.backFormColor = Color.White;
                App_Status.backPanelColor = Color.White;
                App_Status.textColor = Color.FromArgb(42, 42, 49);
                App_Status.iconDashboard = "../../Resources/material-icons_3-0-1_dashboard_35_0_000000_none.png";
                App_Status.iconCart = "../../Resources/font-awesome_4-7-0_shopping-cart_35_0_000000_none.png";
                App_Status.iconChat = "../../Resources/ionicons_2-0-1_chatbox-working_35_0_000000_none.png";
                App_Status.iconProfile = "../../Resources/icomoon-free_2014-12-23_profile_35_0_000000_none.png";
                App_Status.iconGames = "../../Resources/font-awesome_4-7-0_gamepad_35_0_000000_none.png";
                App_Status.iconNoti = "../../Resources/ionicons_2-0-1_android-notifications_35_0_000000_none.png";
            }
            delegateChangeHomePage();
            delegateChangeProfile();
            delegateChangePrivacySettings();
            delegateChangeProfileInfo();
            delegateChangeCart();
            delegateChangeSearch();
            delegateChangeGames();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LogOutConfirmation logOutConfirmation = new LogOutConfirmation();
            logOutConfirmation.StartPosition = FormStartPosition.CenterScreen;
            logOutConfirmation.Show();
        }
    }
}
