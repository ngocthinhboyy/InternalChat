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

        

        

        void TurnOffPanel()
        {
            panel_Dashboard.Visible = false;
            panel_Chat.Visible = false;
            panel_Profile.Visible = false;
            panel_Cart.Visible = false;
            panel_Calendar.Visible = false;
            panel_Games.Visible = false;
            panel_Settings.Visible = false;

        }

        public HomePage()
        {
            InitializeComponent();



            //
            // Profile

           

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
        }

        private void Tab_Profile_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Profile.Visible = true;
        }

        private void Tab_Chat_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Chat.Visible = true;
        }

        private void Tab_Cart_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Cart.Visible = true;
        }

        private void Tab_Calendar_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Calendar.Visible = true;
        }

        private void Tab_Games_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Games.Visible = true;
        }

        private void Tab_Settings_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            TurnOffPanel();
            panel_Settings.Visible = true;
        }











        // Function Profile CLick




    }
}
