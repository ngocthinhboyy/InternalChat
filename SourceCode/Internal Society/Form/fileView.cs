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
    public partial class fileView : Form
    {
        public fileView()
        {
            InitializeComponent();
        }

        public fileView(string url)
        {
            InitializeComponent();
            imageView.ImageLocation = url;
        }
    }
}
