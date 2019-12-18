using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Internal_Society
{
    public delegate void kVoidDelegate(string a);

    public partial class Panel_Sticker : Form
    {
        List <string> urlSticker = new List<string>();
        public static kVoidDelegate ExecuteDelegate;
        private bool isChat = false;
        

        public int soCot = 3;
        public int marginRight = 30;
        public int marginBottom = 30;
        private int NumOfUsersSticker = 0;
        public Panel_Sticker()
        {
            InitializeComponent();
        }
        public Panel_Sticker(bool i)
        {
            InitializeComponent();
            
            panel2.Controls.Clear();

            isChat = i;
            int kIndex = 0;
            int kDefault = -1;
            NumOfUsersSticker = 0;
            foreach (kSticker sticker in ListSticker.data)
            {
                if (sticker.IsOwned)
                {
                    if (kDefault == -1) kDefault = kIndex;
                    Bunifu.Framework.UI.BunifuImageButton btnKun = new Bunifu.Framework.UI.BunifuImageButton();
                    btnKun.Width = 45;
                    btnKun.Height = 45;
                    btnKun.Click += pakage_click;
                    btnKun.BackColor = Color.Transparent;
                    btnKun.ImageLocation = App_Status.urlLocalResources + sticker.Name + "_000.png";
                    btnKun.Tag = kIndex.ToString();
                    loadPakageSticker(btnKun);
                    NumOfUsersSticker++;
                }

                kIndex++;
            }
            

            if(NumOfUsersSticker > 0)
            {
                
                loadStickerInPanel(ListSticker.data[kDefault].Name, ListSticker.data[kDefault].Extension,
                1, ListSticker.data[kDefault].Quantity, ListSticker.data[kDefault].Description);
            }
            
        }

        // Only Show in Cart
        public Panel_Sticker(int index)
        {
            InitializeComponent();
            panel2.Visible = false;
            panel1.Height += 120;
            sticker_model.Location = new Point(25, 25);
            //panel2.Controls.Clear();


        }
        private void pakage_click(object sender, EventArgs e)
        {
            
            Bunifu.Framework.UI.BunifuImageButton btnKun = sender as Bunifu.Framework.UI.BunifuImageButton;

            int kIndex = Convert.ToInt32(btnKun.Tag);
            loadStickerInPanel(ListSticker.data[kIndex].Name, ListSticker.data[kIndex].Extension,
                1, ListSticker.data[kIndex].Quantity, ListSticker.data[kIndex].Description);

        }

        public void InitialLocation()
        {
            this.StartPosition = FormStartPosition.CenterParent;
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
        public void loadStickerInPanel(string stickerName="", string ext="png",int from = 1, int to = 2, string Description = "")
        {
            lb_Description.Text = Description;
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
                if(isChat)
                {
                    st.Enabled = true;
                }
                else
                {
                    st.Enabled = false;
                }
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

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        
    }


    

    
}
