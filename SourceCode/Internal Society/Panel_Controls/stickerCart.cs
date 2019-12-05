using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Internal_Society
{
    public partial class stickerCart : UserControl
    {
        
        public string PakageUrl;
        private int Price;
        private int StickerID;

        public stickerCart()
        {
            InitializeComponent();
           
        }

        private void EnableButtonAdd()
        {
            btn_add.ButtonText = this.Price.ToString();
        }
        private void DisableButtonAdd()
        {
            btn_add.Enabled = false;
            btn_add.ButtonText = "Owned";
        }

        public stickerCart(string urlSticker,int X, int Y, int Price)
        {

            InitializeComponent();
            this.PakageUrl = urlSticker;
            pictureBox1.ImageLocation = urlSticker;
            this.Location = new Point(X, Y);
            this.Price = Price;
        }
        public void SetDetailSticker(string name, string description, bool IsOwned, int ID)
        {
            lbl_name.Text = name;
            lbl_description.Text = description;
            this.StickerID = ID;


            if (IsOwned)
            {
                DisableButtonAdd();
            }
            else
            {
                EnableButtonAdd();
                
            }
        }


        public event EventHandler PreviewButtonClicked;

        protected virtual void OnPrivewButtonClicked(object sender, EventArgs e)
        {
            var handler = PreviewButtonClicked;

            if (handler != null)
                handler(sender, e);
        }


        private void Btn_preview_Click_1(object sender, EventArgs e)
        {
            OnPrivewButtonClicked(this, e);
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            BuyProcess();
        }

        private async void BuyProcess()
        {
           
            string urlRequest = App_Status.urlAPI + "c_Sticker/BuySticker/" + User_Info.k_ID + "/" + StickerID.ToString();
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            

            // await
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            if(data.Success == "1")
            {
                MessageBox.Show("Buy successfully !");
                DisableButtonAdd();
                ListSticker.getSticker();
            }
            else
            {
                MessageBox.Show("Fail !");
            }
        }
    }
}
