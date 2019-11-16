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
    public partial class activeFriend : UserControl
    {
        public activeFriend()
        {
            InitializeComponent();
        }
        public activeFriend(string userName, string userStatus)
        {
            InitializeComponent();
            username.Text = userName;
            activeStatus.Text = userStatus;
        }
        private void ActiveStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
