﻿using System;
using System.Windows.Forms;

namespace Internal_Society
{
    public partial class Panel_Games : UserControl
    {

        public Panel_Games()
        {
            InitializeComponent();
            BuyKey.delegateChangeDiamondGame = new ChangeDiamond(this.Change);
            Internal_Society.Games_LuckyWheel.delegatechangeKeyGame = new ChangeKey(this.ChangeKey);
            Internal_Society.Games_LuckyWheel.delegatechangeGame = new ChangeKey(this.Change);
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeGames = new Panel_Controls.DarkMode(this.ChangeDarkMode);
            lb_Diamond.Text = User_Info.k_Diamond;
            lb_Gold.Text = User_Info.k_Gold;
            lb_KeyWheel.Text = User_Info.k_LuckyWheel;
        }
        public void ChangeKey()
        {
            int key = Convert.ToInt32(lb_KeyWheel.Text);
            key--;
            if(key<0)
            {
                key = 0;
                return;
            }
            lb_KeyWheel.Text = key.ToString();
        }
        public void Change()
        {
            lb_Diamond.Text = User_Info.k_Diamond;
            lb_Gold.Text = User_Info.k_Gold;
            lb_KeyWheel.Text = User_Info.k_LuckyWheel;
        }
        public void ChangeDarkMode()
        {
            this.BackColor = App_Status.backFormColor;
            this.panel1.BackColor = App_Status.backFormColor;
            this.panel2.BackColor = App_Status.backFormColor;
            this.panel3.BackColor = App_Status.backFormColor;
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            BuyKey buyKeyForm = new BuyKey();
            buyKeyForm.StartPosition = FormStartPosition.CenterScreen;
            buyKeyForm.Show();
        }

        private void BtnGameLuckyWheels_Click(object sender, EventArgs e)
        {
            frmLuckyWheel frmLuckyWheel = new frmLuckyWheel();
            frmLuckyWheel.StartPosition = FormStartPosition.CenterScreen;
            frmLuckyWheel.Show();
        }

        private void BtnGameCaro_Click(object sender, EventArgs e)
        {
            frmCaro frmCaro1 = new frmCaro();
            frmCaro1.StartPosition = FormStartPosition.CenterScreen;
            frmCaro1.Show();
        }
    }
}
