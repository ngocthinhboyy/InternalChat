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
using System.IO;
using System.Dynamic;
using Newtonsoft.Json;
using System.Threading;
using System.Web.Script.Serialization;

namespace Internal_Society
{
    
    public partial class chatbox : UserControl
    {
        
        const string urlKun = "../../Resources\\";
        string id_conversation = "1";
        bubble bbl_old = new bubble();
        string json;
        string pMessage = "";
        string pSticker = "";
        string dataMessage = "0";
        int messIndex = 0;
       
        public chatbox()
        {
            Panel_Color_Bubble.NotifyChangeColor = new Notify(this.notifyChangeColor);
            if (!this.DesignMode)
            {
                InitializeComponent();
                //panel2.Controls.RemoveAt(0);
                //panel2.Controls.RemoveAt(0);
                Time_Request.Interval = App_Status.time_delay;
                /*ThreadStart ts_1 = new ThreadStart(threadGetData);
                Thread thrd_1 = new Thread(ts_1);
                thrd_1.Start();*/
                Time_Request.Start();
                Time_Get_Message_Data.Start();
                Queue_Sticker.data = new Queue<string>();
            }
            bbl_old.Top = 0 - bbl_old.Height + 10;
            /*StreamReader read = new StreamReader("conversation_5.txt");
            string a1 = null;
            a1 = read.ReadLine();
            
            while(a1 != null)
            {
                dynamic data_mess = JsonConvert.DeserializeObject(a1);
                string d_mess = data_mess.Message_Data;
                string d_time = data_mess.Time_Data;
                string d_urlPic = data_mess.urlPic;
                if (d_urlPic != "") d_urlPic = urlKun + d_urlPic;

                
                
                string d_id = data_mess.ID;
                if(d_id == id_user) { addInMessage(d_mess, d_time,d_urlPic); }
                if (d_id == id_counterpart) { addOutMessage(d_mess, d_time,d_urlPic); }
                
                a1 = read.ReadLine();
                
            }
            read.Close();*/
        }
        public void notifyChangeColor()
        {
            Label lbl = new Label();
            lbl.Text = "You changed the chat colors.";
            lbl.Location = new Point(this.Width / 3 + 40, bbl_old.Bottom);
            lbl.Width = 300;
            lbl.ForeColor = Color.FromArgb(144, 148, 156);
            panel2.Controls.Add(lbl);
        }
        public void threadGetData()
        {           
            var urlGetData = "https://kunbr0.com/it008/get_conversation_detail.php?c_id=" + id_conversation + "&index=" + messIndex;
            dataMessage = new WebClient().DownloadString(urlGetData);
        }
        public void addInMessage(string kkMessage, int message_type = 0, string urlPic = "", string urlSticker = "", string kkTime = "")
        {
            bubble bbl = new Internal_Society.bubble(kkMessage, urlPic, urlSticker,message_type, kkTime, msgType.In);
            //Xét xem scroll bar tồn tại hay chưa
            if (panel2.VerticalScroll.Visible == false)
                bbl.Location = new Point(this.Width - bbl.Width - 40, 50);
            else
                bbl.Location = new Point(this.Width - bbl.Width - 55, 50);
           
            bbl.Top = bbl_old.Bottom + 20;
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
        
        public void addOutMessage(string kkMessage, int message_type = 0, string urlPic = "", string urlSticker = "", string kkTime = "")
        {

            bubble bbl = new Internal_Society.bubble(kkMessage, urlPic, urlSticker, message_type, kkTime, msgType.Out);
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

            if(txt_input.Text != "")
            {
                string urlPic = "";
                string kInput = txt_input.Text.ToString();
                pMessage = txt_input.Text;
                string inputTime = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
                addInMessage(kInput,0,"","",inputTime);
                ThreadStart ts_1 = new ThreadStart(PushMessage);
                Thread thrd_1 = new Thread(ts_1);
                thrd_1.Start();
                txt_input.Text = "";
            }
        }

        void PushMessage()
        {
            messIndex++;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(@"https://kunbr0.com/it008/add_conversation_message.php?c_id=" + id_conversation + @"&u_id=" + User_Info.k_ID + "&u_message=" + pMessage +"&u_sticker=" + pSticker);
            }
            pMessage = "";
            pSticker = "";
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Send_Click(this, new EventArgs());
            }

        }

        public void ProccessData()
        {
            Time_Request.Stop();
            /*List<Data_Message> list = JsonConvert.DeserializeObject<List<Data_Message>>(dataMessage);
            MessageBox.Show(list.ToString());*/

            //string kkdata = @"{""data"":[{""k_userID"":""518523721"",""name"":""ftyft""}, {""k_userID"":""527032438"",""name"":""ftyftyf""}, {""k_userID"":""527572047"",""name"":""ftgft""}, {""id"":""531141884"",""name"":""ftftft""}]}";

            Conversation_Message dMess = new JavaScriptSerializer().Deserialize<Conversation_Message>(dataMessage);


            /*for(int i = 0; i < dMess.data.Count; i++)
            {
                dMess.data.
            }*/

            for (int i = dMess.data.Count-1; i >= 0; i--)
            {

                byte[] bytes = Encoding.Default.GetBytes(dMess.data[i].Message.ToString());
                dMess.data[i].Message = Encoding.UTF8.GetString(bytes);
                if (Convert.ToInt32(dMess.data[i].Message_id) > messIndex) messIndex = Convert.ToInt32(dMess.data[i].Message_id);

                if (dMess.data[i].User_id == User_Info.k_ID)
                {
                    addInMessage(dMess.data[i].Message.ToString(),Convert.ToInt32(dMess.data[i].Message_type.ToString()),
                        dMess.data[i].Image.ToString(), dMess.data[i].Sticker.ToString(),
                        dMess.data[i].Time.ToString());

                }
                else
                {

                    addOutMessage(dMess.data[i].Message.ToString(), Convert.ToInt32(dMess.data[i].Message_type.ToString()),
                        dMess.data[i].Image.ToString(), dMess.data[i].Sticker.ToString(),
                        dMess.data[i].Time.ToString());
                }

                

            }

            Time_Request.Start();
            dataMessage = "0";
        }

        private void Time_Get_Message_Data_Tick(object sender, EventArgs e)
        {
            if(dataMessage != "0")
            {
                ProccessData();
            }
        }

        

        private void Time_Request_Tick(object sender, EventArgs e)
        {
            if (dataMessage != "0") ProccessData();
            ThreadStart ts_1 = new ThreadStart(threadGetData);
            Thread thrd_1 = new Thread(ts_1);
            thrd_1.Start();

            if (Time_Request.Interval != App_Status.time_delay)
            {
                Time_Request.Interval = App_Status.time_delay;
                Time_Request.Stop();
                Time_Request.Start();
            }

        }

        private void Button_Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
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
            while(Queue_Sticker.data.Count() != 0)
            {
                string inputTime = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
                pSticker = Queue_Sticker.data.Dequeue();
                addInMessage("", 2, "", pSticker, inputTime);


                ThreadStart ts_1 = new ThreadStart(PushMessage);
                Thread thrd_1 = new Thread(ts_1);
                thrd_1.Start();

                
                
                


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
    }
}
