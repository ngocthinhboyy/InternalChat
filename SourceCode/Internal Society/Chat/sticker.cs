using System;
using System.Windows.Forms;

namespace Internal_Society
{
    
    public partial class sticker : UserControl
    {
        public string urlSticker;
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
            Panel_Sticker.ExecuteDelegate(urlSticker);
        }

        
    }
}
