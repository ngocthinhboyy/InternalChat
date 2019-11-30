using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace Internal_Society
{
    public partial class Panel_Profile : UserControl
    {
        public Panel_Profile()
        {
            InitializeComponent();
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
