﻿using System;
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
    public delegate void CloseHomePage();
    public partial class LogOutConfirmation : Form
    {
        public static CloseHomePage delegateCloseHomePage;
        public LogOutConfirmation()
        {
            InitializeComponent();

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm.isClick = true;
            delegateCloseHomePage();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
