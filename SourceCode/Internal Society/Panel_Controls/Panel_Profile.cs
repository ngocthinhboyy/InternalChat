using System;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class Panel_Profile : UserControl
    {
        public Panel_Profile()
        {
            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeProfile = new Panel_Controls.DarkMode(this.ChangeDarkMode);
        }
        public void ChangeDarkMode()
        {
            lblPrivacySettings.ForeColor = lblProfile.ForeColor = App_Status.textColor;
            this.BackColor = App_Status.backPanelColor;
        }
        private void LblProfile_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Visible = false;
            bunifuSeparator1.Left = ((Control)sender).Left;
            bunifuSeparator1.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(bunifuSeparator1);
            bunifuTransition2.HideSync(tabPrivacySettings1);
            bunifuTransition2.ShowSync(tabProfileInfo1);
        }

        private void LblPrivacySettings_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Visible = false;
            bunifuSeparator1.Left = ((Control)sender).Left;
            bunifuSeparator1.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(bunifuSeparator1);
            bunifuTransition2.HideSync(tabProfileInfo1);
            bunifuTransition2.ShowSync(tabPrivacySettings1);
        }
    }
}
