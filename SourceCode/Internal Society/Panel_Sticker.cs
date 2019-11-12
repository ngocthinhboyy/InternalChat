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
        List <string> urlSticker = new List<string>();

        public int soCot = 3;
        public int marginRight = 30;
        public int marginBottom = 30;
        kListPakage klp = new kListPakage();

        public Panel_Sticker()
        {
            InitializeComponent();
            
            panel2.Controls.Clear();

            kPakage kp1 = new kPakage("heohong","png",1,16);
            klp.ListPakage.Add(kp1);
            kPakage kp2 = new kPakage("Luci_&_Daisy", "png", 1, 25);
            klp.ListPakage.Add(kp2);
            kPakage kp3 = new kPakage("foxie", "png", 1, 19);
            klp.ListPakage.Add(kp3);
            kPakage kp4 = new kPakage("quick_answer", "png", 1, 7);
            klp.ListPakage.Add(kp4);
            kPakage kp5 = new kPakage("toto_dog", "png", 1, 20);
            klp.ListPakage.Add(kp5);
            kPakage kp6 = new kPakage("tonton_friends", "png", 1, 20);
            klp.ListPakage.Add(kp6);
            kPakage kp7 = new kPakage("pikalong", "png", 1, 14);
            klp.ListPakage.Add(kp7);
            kPakage kp8 = new kPakage("tien_len_vn", "png", 1, 10);
            klp.ListPakage.Add(kp8);
            kPakage kp9 = new kPakage("rong_vang", "png", 1, 19);
            klp.ListPakage.Add(kp9);
            kPakage kp10 = new kPakage("dev", "png", 1, 3);
            klp.ListPakage.Add(kp10);


            for (int i = 0; i < klp.ListPakage.Count; i++)
            {
                Bunifu.Framework.UI.BunifuImageButton btnKun = new Bunifu.Framework.UI.BunifuImageButton();
                btnKun.Width = 45;
                btnKun.Height = 45;
                btnKun.Click += pakage_click;
                btnKun.BackColor = Color.Transparent;
                btnKun.ImageLocation = "../../Resources/"+klp.ListPakage[i].PakageName+"_000.png";
                loadPakageSticker(btnKun);
                
            }

            
            loadStickerInPanel(klp.ListPakage[0].PakageName, klp.ListPakage[0].PakageExt,
                klp.ListPakage[0].PakageFrom, klp.ListPakage[0].PakageTo);

            
        }

        private void pakage_click(object sender, EventArgs e)
        {
            
            Bunifu.Framework.UI.BunifuImageButton btnKun = sender as Bunifu.Framework.UI.BunifuImageButton;
            int kIndex = panel2.Controls.IndexOf(btnKun);
            loadStickerInPanel(klp.ListPakage[kIndex].PakageName, klp.ListPakage[kIndex].PakageExt,
                klp.ListPakage[kIndex].PakageFrom, klp.ListPakage[kIndex].PakageTo);

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


        // Tên gói sticker , đuôi file, bắt đầu, kết thúc
        public void loadStickerInPanel(string stickerName="", string ext="png",int from = 1, int to = 2)
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = false;
            
            int kTop = sticker_model.Top;
            int kLeft = sticker_model.Left;
            for (int i = from; i < to+1 ; i++)
            {
                panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum;
                string index;
                if (i < 10) { index = "_00" + i.ToString(); } else { index = "_0" + i.ToString(); }
                sticker st = new sticker(stickerName + index + "." + ext);
                st.Left = kLeft;
                st.Top = kTop;

                panel1.Controls.Add(st);
                
                if (i % soCot == 0 && i / soCot > 0)
                {
                    kLeft = sticker_model.Left;
                    kTop = sticker_model.Top + (sticker_model.Height + marginBottom) * (i / soCot);
                }
                else
                {
                    kLeft = kLeft + sticker_model.Width + marginRight;
                }

            }
            panel1.AutoScroll = true;
        }

        
        int pLeft = 10;
        int pMarginRight = 10;
        

        public void loadPakageSticker(Bunifu.Framework.UI.BunifuImageButton btnKun)
        {
            btnKun.Top = pakage_model.Top;
            btnKun.Left = pLeft;
            pLeft = pLeft + btnKun.Width + pMarginRight;
            panel2.Controls.Add(btnKun);
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
        }

        
    }


    public class kListPakage
    {
        private List<kPakage> listPakage;

        public kListPakage()
        {
            listPakage = new List<kPakage>();
        }

        public List<kPakage> ListPakage { get => listPakage; set => listPakage = value; }
    }

    public class kPakage
    {
        private string pakageName;
        private string pakageExt;
        private int pakageFrom;
        private int pakageTo;

        public kPakage()
        {

        }
        public kPakage(string a, string b, int c, int d)
        {
            pakageName = a;
            pakageExt = b;
            pakageFrom = c;
            pakageTo = d;
        }
        
        
        public string PakageName { get => pakageName; set => pakageName = value; }
        public string PakageExt { get => pakageExt; set => pakageExt = value; }
        public int PakageFrom { get => pakageFrom; set => pakageFrom = value; }
        public int PakageTo { get => pakageTo; set => pakageTo = value; }
    }
}
