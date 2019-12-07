using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class Panel_Games : UserControl
    {
        public Panel_Games()
        {
            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeGames = new Panel_Controls.DarkMode(this.ChangeDarkMode);
        }
        public void ChangeDarkMode()
        {
            this.BackColor = App_Status.backFormColor;
        }
    }
}
