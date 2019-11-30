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
    public partial class Panel_Cart : UserControl
    {
        List<stickerCart> listSticker = new List<stickerCart>(12);
        kListPakage klp = new kListPakage();
        public Panel_Cart()
        {
            InitializeComponent();
            Internal_Society.Panel_Controls.tabPrivacySettings.delegateChangeCart = new Panel_Controls.DarkMode(this.ChangeDarkMode);
            kPakage kp1 = new kPakage("heohong");
            klp.ListPakage.Add(kp1);
            kPakage kp2 = new kPakage("Luci_&_Daisy");
            klp.ListPakage.Add(kp2);
            kPakage kp3 = new kPakage("foxie");
            klp.ListPakage.Add(kp3);
            kPakage kp4 = new kPakage("quick_answer");
            klp.ListPakage.Add(kp4);
            kPakage kp5 = new kPakage("toto_dog");
            klp.ListPakage.Add(kp5);
            kPakage kp6 = new kPakage("tonton_friends");
            klp.ListPakage.Add(kp6);
            kPakage kp7 = new kPakage("pikalong");
            klp.ListPakage.Add(kp7);
            kPakage kp8 = new kPakage("tien_len_vn");
            klp.ListPakage.Add(kp8);
            kPakage kp9 = new kPakage("rong_vang");
            klp.ListPakage.Add(kp9);
            kPakage kp10 = new kPakage("dev");
            klp.ListPakage.Add(kp10);
            kPakage kp11 = new kPakage("tiger");
            klp.ListPakage.Add(kp11);
            //MessageBox.Show(klp.ListPakage.Count.ToString());
            stickerCart stick;
            for (int i = 0; i < 11; i++)
            {
                string url = "../../Resources/" + klp.ListPakage[i].PakageName + "_000.png";
                if( i % 2 == 0)
                {
                    stick = new stickerCart(url, 30, 50 + 80 * i);
                    listSticker.Add(stick);
                }
                else
                {
                    stick = new stickerCart(url, 390, 50 + 80 * (i - 1));
                    listSticker.Add(stick);
                }
                panel2.Controls.Add(stick);
            }
            listSticker[0].SetDetailSticker("Pink Pig", "");
            listSticker[1].SetDetailSticker("Lucy and Daisy", "");
            listSticker[2].SetDetailSticker("Foxie", "");
            listSticker[3].SetDetailSticker("Quick Answer", "");
            listSticker[4].SetDetailSticker("ToTo dog", "");
            listSticker[5].SetDetailSticker("TonTon Friend", "");
            listSticker[6].SetDetailSticker("Pikalong", "");
            listSticker[7].SetDetailSticker("Tiến Lên Việt Nam", "");
            listSticker[8].SetDetailSticker("Rồng vàng", "");
            listSticker[9].SetDetailSticker("Dev", "");
            listSticker[10].SetDetailSticker("Kingdom of Tigers", "");
        }
        public void ChangeDarkMode()
        {
            panel1.BackColor = panel2.BackColor = App_Status.backPanelColor;
        }
    }
}
