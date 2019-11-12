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
    public partial class friendInfo : UserControl
    {
        public friendInfo()
        {
            InitializeComponent();
        }
        public friendInfo(string userName, string userFullname)
        {
            InitializeComponent();
            username.Text = userName;
            if (userFullname == "")
            {
                userFullname = "Người dùng Internal Chat";
            }
            user_fullname.Text = userFullname;
        }

        bool isClicked = false;
        private void btn_addFriend_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                btn_addFriend.BackColor = Color.FromArgb(227, 38, 54);
                btn_addFriend.Normalcolor = Color.FromArgb(227, 38, 54);
                btn_addFriend.OnHovercolor = Color.FromArgb(217, 38, 54);
                btn_addFriend.Text = "Remove request";
                isClicked = !isClicked;
            }
            else
            {
                btn_addFriend.BackColor = Color.FromArgb(46, 139, 87);
                btn_addFriend.Normalcolor = Color.FromArgb(46, 139, 87);
                btn_addFriend.OnHovercolor = Color.FromArgb(36, 129, 77);
                btn_addFriend.Text = "Add friend";
                isClicked = !isClicked;
            }
            
            
        }
    }
}
