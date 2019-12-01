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
    public partial class stickerCart : UserControl
    {
        public stickerCart()
        {
            InitializeComponent();
        }
        public stickerCart(string urlSticker,int X, int Y)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = urlSticker;
            this.Location = new Point(X, Y);
        }
        public void SetDetailSticker(string name, string description)
        {
            lbl_name.Text = name;
            lbl_description.Text = description;
        }

        private void Btn_preview_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            switch (lbl_name.Text)
            {
                case "Pink Pig":
                    {
                        x = 0;
                        break;
                    }
                case "Lucy and Daisy":
                    {
                        x = 1;
                        break;
                    }
                case "Foxie":
                    {
                        x = 2;
                        break;
                    }
                case "Quick Answer":
                    {
                        x = 3;
                        break;
                    }
                case "ToTo dog":
                    {
                        x = 4;
                        break;
                    }
                case "TonTon Friend":
                    {
                        x = 5;
                        break;
                    }
                case "Pikalong":
                    {
                        x = 6;
                        break;
                    }
                case "Tiến Lên Việt Nam":
                    {
                        x = 7;
                        break;
                    }
                case "Rồng vàng":
                    {
                        x = 8;
                        break;
                    }
                case "Dev":
                    {
                        x = 9;
                        break;
                    }
                case "Kingdom of Tigers":
                    {
                        x = 10;
                        break;
                    }
            }
            Panel_Sticker pn_sticker = new Panel_Sticker(x);
            pn_sticker.Show();
        }
    }
}
