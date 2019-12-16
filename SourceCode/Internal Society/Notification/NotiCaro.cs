using System;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class NotiCaro : UserControl
    {
        int GameID;
        string friendName;
        public NotiCaro()
        {
            InitializeComponent();
        }

        public NotiCaro(string fullname, int GameID)
        {
            InitializeComponent();
            this.GameID = GameID;
            lb_Fullname.Text = fullname;
            friendName = fullname;
        }


        private void Btn_Accept_Click(object sender, EventArgs e)
        {

            frmCaro frmCaro2 = new frmCaro(GameID,friendName);
            frmCaro2.Show();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {

        }
    }
}
