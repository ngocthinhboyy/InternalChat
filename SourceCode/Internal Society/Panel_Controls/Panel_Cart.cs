using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Internal_Society
{
    public partial class Panel_Cart : UserControl
    {
        List<stickerCart> listSticker = new List<stickerCart>();
        Panel_Sticker pn_sticker = new Panel_Sticker(0);

        private void PreviewButtonClicked(object sender, EventArgs e)
        {
            stickerCart sKC = sender as stickerCart;
            int kIndex = Convert.ToInt32(sKC.Tag);

            pn_sticker.loadStickerInPanel(ListSticker.data[kIndex].Name,
               ListSticker.data[kIndex].Extension, 1, ListSticker.data[kIndex].Quantity,
               ListSticker.data[kIndex].Description);
            pn_sticker.Show();
        }

        private void UpdateData()
        {
            lb_Gold.Text = User_Info.k_Gold;
            lb_Diamond.Text = User_Info.k_Diamond;
        }
            public Panel_Cart()
        {
            InitializeComponent();
            lb_Gold.Text = User_Info.k_Gold;
            lb_Diamond.Text = User_Info.k_Diamond;
            BuyKey.delegateChangeDiamondCart = new ChangeDiamond(this.UpdateData);
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeCart = new Panel_Controls.DarkMode(this.ChangeDarkMode);
            UpdateData();
            Internal_Society.stickerCart.delegateUpdateGold = new UpdateGold(this.UpdateGoldAsync);
        }
        public async void UpdateGoldAsync()
        {
            //string urlSearchUser = App_Status.urlAPI + "c_User/GetUserInfo/" + User_Info.k_ID ;
            //string result = new WebClient().DownloadString(urlSearchUser);
            //User_Info.k_Gold = result.Gol
            //lb_Diamond.Text = User_Info.k_Diamond;
            string urlRequest = App_Status.urlAPI + "c_User/GetUserInfo/" + User_Info.k_ID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });

            // await
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            User_Info.k_Gold = data.Gold;
            User_Info.k_Diamond = data.Diamond;
            UpdateData();
        }
        private void ShowDetail()
        {
            stickerCart stick;
            
            for (int i = 0; i < ListSticker.data.Count; i++)
            {
                string url = App_Status.urlLocalResources + ListSticker.data[i].Name + "_000.png";
                if (i % 2 == 0)
                {
                    stick = new stickerCart(url, 30, 50 + 80 * i,Convert.ToInt32(ListSticker.data[i].Price));
                    stick.SetDetailSticker(ListSticker.data[i].Description,"",
                        ListSticker.data[i].IsOwned, ListSticker.data[i].ID);
                    stick.Tag = i.ToString();
                    
                    listSticker.Add(stick);
                }
                else
                {
                    stick = new stickerCart(url, 390, 50 + 80 * (i - 1), Convert.ToInt32(ListSticker.data[i].Price));
                    stick.SetDetailSticker(ListSticker.data[i].Description, "",
                        ListSticker.data[i].IsOwned, ListSticker.data[i].ID);
                    stick.Tag = i.ToString();
                    listSticker.Add(stick);
                }
                stick.PreviewButtonClicked += PreviewButtonClicked;
                panel2.Controls.Add(stick);
            }
        }

        public void ChangeDarkMode()
        {
            panel1.BackColor = panel2.BackColor = panel3.BackColor = App_Status.backPanelColor;
            lb_Diamond.ForeColor = lb_Gold.ForeColor = App_Status.textColor;
        }

        private void Timer_GetSticker_Tick(object sender, EventArgs e)
        {
            if(ListSticker.data.Count > 0)
            {
                ShowDetail();
                Timer_GetSticker.Stop();
            }
        }
    }
}
