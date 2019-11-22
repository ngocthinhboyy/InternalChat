﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Dynamic;
using Newtonsoft.Json;
using System.Threading;
using System.Web.Script.Serialization;

namespace Internal_Society
{

    public partial class chatbox : UserControl
    {
        #region Define Variable
        const string urlKun = "../../Resources\\";
        string id_conversation = "1";
        bubble bbl_old = new bubble();
        string json;
        string pMessage = "";
        string pSticker = "";
        int messIndex = 0;
        #endregion

        public chatbox()
        {
            Panel_Color_Bubble.NotifyChangeColor = new Notify(this.notifyChangeColor);
            if (!this.DesignMode)
            {
                InitializeComponent();
                Queue_Sticker.data = new Queue<string>();
            }
            bbl_old.Top = 0 - bbl_old.Height + 10;

        }
        public void notifyChangeColor()
        {
            Label lbl = new Label();
            lbl.Text = "You changed the chat colors.";
            lbl.Location = new Point(this.Width / 3 + 40, bbl_old.Bottom);
            lbl.Width = 150;
            lbl.BackColor = Color.Transparent;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.FromArgb(144, 148, 156);
            lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            panel2.Controls.Add(lbl);
        }

        public void addInMessage(string user_ID, string message_ID, string message_Type,
            string message_Detail, string message_Time)
        {
            bubble bbl = new Internal_Society.bubble(user_ID, message_ID, message_Type,
             message_Detail, message_Time, msgType.In);
            //Xét xem scroll bar tồn tại hay chưa
            if (panel2.VerticalScroll.Visible == false)
                bbl.Location = new Point(this.Width - bbl.Width - 40, 50);
            else
                bbl.Location = new Point(this.Width - bbl.Width - 55, 50);

            bbl.Top = bbl_old.Bottom + 25;
            bbl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            panel2.Controls.Add(bbl);
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
            bbl_old = bbl;
            if (Panel_Color_Bubble.isChangedColor == true)
            {
                foreach (Control x in panel2.Controls)
                {
                    if (x is bubble)
                    {
                        ((bubble)x).ChangeColorBubble();
                        Panel_Color_Bubble.isChangedColor = false;
                    }
                }
            }
        }

        public void addOutMessage(string user_ID, string message_ID, string message_Type,
            string message_Detail, string message_Time)
        {

            bubble bbl = new Internal_Society.bubble(user_ID, message_ID, message_Type,
             message_Detail, message_Time, msgType.Out);
            PictureBox pic = new PictureBox();
            pic.Size = new Size(40, 40);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            bbl.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            pic.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            bbl.Location = new Point(90, 50);
            bbl.Top = bbl_old.Bottom + 20;
            pic.Location = new Point(20, bbl.Top);
            pic.ImageLocation = "../../Resources/user_001.png";
            panel2.Controls.Add(pic);
            panel2.Controls.Add(bbl);
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
            bbl_old = bbl;

        }
        private void button_Send_Click(object sender, EventArgs e)
        {

            if (txt_input.Text != "")
            {
                string urlPic = "";
                string kInput = txt_input.Text.ToString();
                pMessage = txt_input.Text;
                string inputTime = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
                addInMessage(User_Info.k_ID, "-1", "0", pMessage, "now");
                PushMessageAsync("0", pMessage);
                txt_input.Text = "";
            }
        }


        public async void PushMessageAsync(string message_Type, string message_Detail)
        {
            messIndex++;
            var urlPushData = App_Status.urlAPI + "c_Message/Add_Conversation_Message/" + id_conversation + "/" + User_Info.k_ID +
                "/" + message_Type + "/" + message_Detail;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlPushData); });
            // await
            string result = await getStringTask;

            // Khi send xog thi lam function tiep theo...
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Send_Click(this, new EventArgs());
            }

        }

        public void ProccessData(string dataMessage)
        {
            TimeRequest.Stop();
            TimeRequest.Start();
            Conversation_Message dMess = new JavaScriptSerializer().Deserialize<Conversation_Message>(dataMessage);
            if (!dMess.success) return;
            for (int i = dMess.data.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(dMess.data[i].message_ID) > messIndex) messIndex = Convert.ToInt32(dMess.data[i].message_ID);

                if (dMess.data[i].user_ID == User_Info.k_ID)
                {
                    addInMessage(User_Info.k_ID, dMess.data[i].message_ID.ToString(), dMess.data[i].message_Type.ToString(),
                        dMess.data[i].message_Detail.ToString(), dMess.data[i].message_Time.ToString());

                }
                else
                {

                    addOutMessage(User_Info.k_ID, dMess.data[i].message_ID.ToString(), dMess.data[i].message_Type.ToString(),
                        dMess.data[i].message_Detail.ToString(), dMess.data[i].message_Time.ToString());
                }



            }
            //TimeRequest.Start();
        }


        public async void GetMessageAsync()
        {
            var urlGetData = App_Status.urlAPI + "c_Message/Get_Conversation_Message/" + id_conversation + "/" + messIndex;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlGetData); });
            // await
            string result = await getStringTask;

            ProccessData(result);
        }




        private void Button_Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName);
                MessageBox.Show(Path.GetFileName(dialog.FileName));
            }
        }

        Panel_Sticker pn_Sticker = new Panel_Sticker();
        private void Button_Sticker_Click(object sender, EventArgs e)
        {
            Time_Sticker.Start();
            pn_Sticker.Show();
        }
        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Time_Sticker.Stop();
            pn_Sticker.Hide();
            pn_Color_Bubble.Hide();
        }

        public void AddStickerFromQueue()
        {
            while (Queue_Sticker.data.Count() != 0)
            {
                string inputTime = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
                pSticker = Queue_Sticker.data.Dequeue();
                addInMessage(User_Info.k_ID, "-1", "1", pSticker, inputTime);
                PushMessageAsync("1", pSticker);
            }
        }

        private void Time_Sticker_Tick(object sender, EventArgs e)
        {
            AddStickerFromQueue();
        }
        Panel_Color_Bubble pn_Color_Bubble = new Panel_Color_Bubble();

        private void Button_More_Click(object sender, EventArgs e)
        {
            pn_Color_Bubble.Show();
        }

        private void TimeRequest_Tick(object sender, EventArgs e)
        {
            TimeRequest.Stop();
            GetMessageAsync();
        }
    }
}
