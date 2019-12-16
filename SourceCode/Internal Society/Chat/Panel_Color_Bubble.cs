using System;
using System.Drawing;
using System.Windows.Forms;

namespace Internal_Society
{
    //Tạo delegate để gọi hàm tạo label bên chatbox

    public delegate void Notify(Color a, Color b, int colorID);

    public partial class Panel_Color_Bubble : Form
    {
        public static Notify SetColor;
        //Màu khởi tạo là blue.
        private Color LeftColor = Color.FromArgb(0, 132, 255);
        private Color RightColor = Color.FromArgb(0, 132, 255);
        public Panel_Color_Bubble()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            LeftColor = ColorData.Color_Left_1;
            RightColor = ColorData.Color_Right_1;

            SetColor(LeftColor, RightColor,1);
            this.Hide();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            LeftColor = ColorData.Color_Left_2;
            RightColor = ColorData.Color_Right_2;

            SetColor(LeftColor, RightColor,2);
            this.Hide();
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            LeftColor = ColorData.Color_Left_4;
            RightColor = ColorData.Color_Right_4;

            SetColor(LeftColor, RightColor,4);
            this.Hide();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            LeftColor = ColorData.Color_Left_3;
            RightColor = ColorData.Color_Right_3;

            SetColor(LeftColor, RightColor,3);
            this.Hide();
        }

        private void BunifuImageButton8_Click(object sender, EventArgs e)
        {
            LeftColor = ColorData.Color_Left_8;
            RightColor = ColorData.Color_Right_8;

            SetColor(LeftColor, RightColor,8);
            this.Hide();
        }

        private void BunifuImageButton7_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = ColorData.Color_Left_7;

            SetColor(LeftColor, RightColor,7);
            this.Hide();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = ColorData.Color_Left_5;

            SetColor(LeftColor, RightColor,5);
            this.Hide();
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = ColorData.Color_Left_6;

            SetColor(LeftColor, RightColor,6);
            this.Hide();
        }

        private void BunifuImageButton12_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = ColorData.Color_Left_12;

            SetColor(LeftColor, RightColor,12);
            this.Hide();
        }

        private void BunifuImageButton11_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = ColorData.Color_Left_11;

            SetColor(LeftColor, RightColor,11);
            this.Hide();
        }

        private void BunifuImageButton9_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = ColorData.Color_Left_9;

            SetColor(LeftColor, RightColor,9);
            this.Hide();
        }

        private void BunifuImageButton10_Click(object sender, EventArgs e)
        {
            LeftColor = RightColor = ColorData.Color_Left_10;

            SetColor(LeftColor, RightColor,10);
            this.Hide();
        }
    }
}
