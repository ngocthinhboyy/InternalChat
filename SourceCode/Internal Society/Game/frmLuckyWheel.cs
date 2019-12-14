using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class frmLuckyWheel : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public frmLuckyWheel()
        {
            InitializeComponent();
            lb_Diamond.Text = User_Info.k_Diamond;
            lb_Gold.Text = User_Info.k_Gold;
            lb_KeyWheel.Text = User_Info.k_LuckyWheel;
            Internal_Society.Games_LuckyWheel.delegatechangeKeyFrmGame = new ChangeKey(this.ChangeKey);
            Internal_Society.Games_LuckyWheel.delegatechangeFrmGame = new ChangeKey(this.Change);
            BuyKey.delegateChangeDiamondFrmGame = new ChangeDiamond(this.UpdateData);
        }

        private void UpdateData()
        {
            lb_Diamond.Text = User_Info.k_Diamond;
            lb_KeyWheel.Text = User_Info.k_LuckyWheel;
        }

        private void Change()
        {
            lb_Diamond.Text = User_Info.k_Diamond;
            lb_Gold.Text = User_Info.k_Gold;
            lb_KeyWheel.Text = User_Info.k_LuckyWheel;
        }

        private void ChangeKey()
        {
            int key = Convert.ToInt32(lb_KeyWheel.Text);
            key--;
            if (key < 0)
            {
                key = 0;
                return;
            }
            lb_KeyWheel.Text = key.ToString();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLuckyWheel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FrmLuckyWheel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void FrmLuckyWheel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Games_LuckyWheel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Games_LuckyWheel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Games_LuckyWheel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
