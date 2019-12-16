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
    public partial class RemoveFriend : Form
    {
        public RemoveFriend()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            //friendInfo.isRemove = true;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //friendInfo.isRemove = false;
            this.Close();
        }
    }
}
