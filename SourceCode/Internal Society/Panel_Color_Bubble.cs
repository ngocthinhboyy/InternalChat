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
    //Tạo delegate để gọi hàm tạo label bên chatbox
    public delegate void Notify();
    public partial class Panel_Color_Bubble : Form
    {
        public static Notify NotifyChangeColor;
        public static bool isChangedColor = false;
        static public Color LeftColor = Color.FromArgb(0, 132, 255);
        static public Color RightColor = Color.FromArgb(0, 132, 255);
        public Panel_Color_Bubble()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            LeftColor = Color.FromArgb(0, 229, 255);
            RightColor = Color.FromArgb(167, 151, 255);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            LeftColor = Color.FromArgb(0, 223, 187);
            RightColor = Color.FromArgb(110, 223, 0);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            LeftColor = Color.FromArgb(146, 0, 255);
            RightColor = Color.FromArgb(0, 95, 255);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            LeftColor = Color.FromArgb(255, 79, 0);
            RightColor = Color.FromArgb(255, 150, 22);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton8_Click(object sender, EventArgs e)
        {
            LeftColor = Color.FromArgb(14, 230, 183);
            RightColor = Color.FromArgb(25, 201, 255);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton7_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = Color.FromArgb(68, 190, 199);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = Color.FromArgb(19, 207, 19);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = Color.FromArgb(32, 206, 245);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton12_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = Color.FromArgb(255, 92, 161);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton11_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = Color.FromArgb(255, 195, 0);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton9_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = Color.FromArgb(118, 70, 255);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }

        private void BunifuImageButton10_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = Color.FromArgb(0, 132, 255);
            isChangedColor = true;
            NotifyChangeColor();
            this.Hide();
        }
    }
}
