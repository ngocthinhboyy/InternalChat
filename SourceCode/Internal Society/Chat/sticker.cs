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
    public partial class sticker : UserControl
    {
        private string urlSticker;
        public string name;
        public sticker()
        {
            InitializeComponent();
            
        }

        public sticker(string urlSticker)
        {
            InitializeComponent();
            this.urlSticker = urlSticker;
            stickerBox.ImageLocation = "../../Resources/"+urlSticker;
        }

        private void StickerBox_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton btnKun = sender as Bunifu.Framework.UI.BunifuImageButton;
            
            Queue_Sticker.data.Enqueue(urlSticker);
        }
    }
}
