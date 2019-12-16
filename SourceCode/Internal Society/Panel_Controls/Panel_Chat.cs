﻿using System;
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
    public partial class Panel_Chat : UserControl
    {
        public Panel_Chat(int conversation_id, int ColorID = 0)
        {
            InitializeComponent();
            //MessageBox.Show("1");
            Internal_Society.chatbox cb = new Internal_Society.chatbox(conversation_id, ColorID);
            cb.Dock = DockStyle.Fill;
            this.Controls.Add(cb);
        }
    }
}
