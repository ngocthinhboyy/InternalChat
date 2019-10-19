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
    public partial class Panel_Sticker : Form
    {
        public Panel_Sticker()
        {
            InitializeComponent();
        }

        public void InitialLocation()
        {
            this.Top = App_Status.HomePage_Top;
            this.Left = App_Status.HomePage_Left + App_Status.HomePage_Width + 10;
        }

        private void Panel_Sticker_Load(object sender, EventArgs e)
        {
            InitialLocation();
        }

        private void Panel_Sticker_Shown(object sender, EventArgs e)
        {
            InitialLocation();
        }

        private void Sticker_01_Click(object sender, EventArgs e)
        {
            Queue_Sticker.data.Enqueue("heohong_001.png");
        }

        private void Sticker_02_Click(object sender, EventArgs e)
        {
            Queue_Sticker.data.Enqueue("heohong_002.png");
        }

        private void Sticker_03_Click(object sender, EventArgs e)
        {
            Queue_Sticker.data.Enqueue("heohong_003.png");
        }

        private void Sticker_04_Click(object sender, EventArgs e)
        {
            Queue_Sticker.data.Enqueue("heohong_004.png");
        }

        private void Sticker_05_Click(object sender, EventArgs e)
        {
            Queue_Sticker.data.Enqueue("heohong_005.png");
        }

        private void Sticker_06_Click(object sender, EventArgs e)
        {
            Queue_Sticker.data.Enqueue("heohong_006.png");
        }
    }
}
