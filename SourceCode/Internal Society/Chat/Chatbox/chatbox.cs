using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using xNet;
using System.Text;
using System.Net.Http;

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
        bool isReceiveFromMe = true;
        private static int sequenceSticker = -1;
        Internal_Society.loading loading = new Internal_Society.loading();
        public static readonly HttpClient client = new HttpClient();

        #endregion
        public static int x = 0;
        public chatbox()
        {

        }
        public chatbox(int conversation_id)
        {
            id_conversation = conversation_id.ToString();

            if (!this.DesignMode)
            {
                InitializeComponent();
                Queue_Sticker.data = new Queue<string>();
            }
            bbl_old.Top = 0 - bbl_old.Height + 10;

            //loading.Dock = DockStyle.Fill;
            loading.Location = new Point(this.Width / 2 - 50, 100);
            panel2.Controls.Add(loading);
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


            foreach (Control x in panel2.Controls)
            {
                if (x is bubble)
                {
                    ((bubble)x).ChangeColorBubble();

                }
            }
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
            /*if (Panel_Color_Bubble.isChangedColor == true)
            {
                foreach (Control x in panel2.Controls)
                {
                    if (x is bubble)
                    {
                        ((bubble)x).ChangeColorBubble();
                        Panel_Color_Bubble.isChangedColor = false;
                    }
                }
            }*/
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
                addInMessage(User_Info.k_ID, "-1", "text", @pMessage, "now");
                PushMessageAsync("text", pMessage);
                txt_input.Text = "";
            }
        }


        public async void PushMessageAsync(string message_Type, string message_Detail)
        {
            /*messIndex++;
            message_Detail = MaHoa.EncryptDecrypt2(message_Detail,App_Status.keyKun);
            var urlPushData = App_Status.urlAPI + "c_Message/Add_Conversation_Message/" + id_conversation + "/" + User_Info.k_ID +
                "/" + message_Type + "?data=" + message_Detail;
            try
            {
                Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlPushData); });
                // await
                string result = await getStringTask;

                // Khi send xog thi lam function tiep theo...
            }
            catch
            {
                MessageBox.Show("Connection Error");
            }*/

            message_Detail = MaHoa.EncryptDecrypt2(message_Detail, App_Status.keyKun);
            var values = new Dictionary<string, string>
                {
                    { "data", message_Detail },
                };
            var urlPushData = App_Status.urlAPI + "c_Message/Add_Conversation_Message/" + id_conversation + "/" + User_Info.k_ID +
                "/" + message_Type;

            var content = new System.Net.Http.FormUrlEncodedContent(values);

            var response = await client.PostAsync(urlPushData, content);

            var responseString = await response.Content.ReadAsStringAsync();

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_Send_Click(this, new EventArgs());
            }

        }

        public async void ProccessData(string dataMessage)
        {
            TimeRequest.Stop();
            TimeRequest.Start();

            Conversation_Message dMess = new JavaScriptSerializer().Deserialize<Conversation_Message>(dataMessage);
            if (!dMess.success) return;
            for (int i = dMess.data.Count - 1; i >= 0; i--)
            {
                if (dMess.data[i].message_Type != "image")
                    dMess.data[i].message_Detail = MaHoa.EncryptDecrypt2(dMess.data[i].message_Detail.ToString(), App_Status.keyKun);



                if (Convert.ToInt32(dMess.data[i].message_ID) > messIndex) messIndex = Convert.ToInt32(dMess.data[i].message_ID);

                if (dMess.data[i].user_ID == User_Info.k_ID)
                {
                    if (isReceiveFromMe)
                        addInMessage(User_Info.k_ID, dMess.data[i].message_ID.ToString(), dMess.data[i].message_Type.ToString(),
                        dMess.data[i].message_Detail.ToString(), dMess.data[i].message_Time.ToString());

                }
                else
                {

                    addOutMessage(User_Info.k_ID, dMess.data[i].message_ID.ToString(), dMess.data[i].message_Type.ToString(),
                        dMess.data[i].message_Detail.ToString(), dMess.data[i].message_Time.ToString());
                }
            }
            isReceiveFromMe = false;
            //TimeRequest.Start();

            //string urlRequest = App_Status.urlAPI + "c_Friend/Get_FriendList/" + User_Info.k_ID;
            ////MessageBox.Show(urlRequest);
            //Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            //string result = await getStringTask;
            //FriendList friend = new JavaScriptSerializer().Deserialize<FriendList>(result);
            ////MessageBox.Show(result);
            //if (!friend.success) return;
            ////MessageBox.Show("Hello");
            ////MessageBox.Show(friend.data.Count.ToString());
            //int lastSeenIndex = 0;
            //for (int i = friend.data.Count - 1; i >= 0; i--)
            //{
            //    //MessageBox.Show(friend.data[i].friend_Conversation_ID.ToString());
            //    if (friend.data[i].friend_Conversation_ID == id_conversation && friend.data[i].lastSeen_ID != dMess.data[0].message_ID)
            //    {
            //        //App_Status.message++;
            //        //delegateMessage();
            //        //delegateNotiMess();
            //        lastSeenIndex = Convert.ToInt32(friend.data[i].lastSeen_ID);
            //        //x++;
            //        break;
            //    }
            //}

            //if (this.Visible == true)
            //{
            //    //int lastSeenindex = 
            //    string urlRequest1 = App_Status.urlAPI + "c_Message/UpdateLastSeen/" + id_conversation + "/" + User_Info.k_ID + "/" + dMess.data[0].message_ID;
            //    Task<string> getStringTask1 = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            //    if (App_Status.message > 0)
            //    {
            //        //int last
            //        App_Status.message = App_Status.message -  lastSeenIndex;
            //        delegateMessage();
            //    }
            //}
            //else
            //{
                
            //}
        }



        public async void GetMessageAsync()
        {
            try
            {
                var urlGetData = App_Status.urlAPI + "c_Message/Get_Conversation_Message/" + id_conversation + "/" + messIndex;
                Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlGetData); });
                // await
                string result = await getStringTask;
                loading.Visible = false;

                byte[] bytes = Encoding.Default.GetBytes(result);
                result = Encoding.UTF8.GetString(bytes);

                ProccessData(result);
            }
            catch
            {
                MessageBox.Show("Connection Error");
            }

        }




        private void Button_Attach_Click(object sender, EventArgs e)
        {
            FileUpload fu = new FileUpload(App_Status.urlUpload, id_conversation ,"otherFile");
            if (fu.UploadFile("otherFile"))
            {
                addInMessage(User_Info.k_ID, "", "otherLocalFile", fu.FilePath, "");
            }
        }

        Panel_Sticker pn_Sticker = new Panel_Sticker();
        private void Button_Sticker_Click(object sender, EventArgs e)
        {
            Panel_Sticker.ExecuteDelegate = AddSticker;
            
            if (!pn_Sticker.IsDisposed)
            {
                if (sequenceSticker != ListSticker.Sequence)
                {
                    pn_Sticker.Close();
                    pn_Sticker = new Panel_Sticker();
                }
                pn_Sticker.Show();
            }
            else
            {
                pn_Sticker = new Panel_Sticker();
                pn_Sticker.Show();
            }

            sequenceSticker = ListSticker.Sequence;
        }
        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            
            pn_Sticker.Hide();
            pn_Color_Bubble.Hide();
        }


        public void AddSticker(string pSticker)
        {
                string inputTime = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
                addInMessage(User_Info.k_ID, "-1", "sticker", pSticker, inputTime);
                PushMessageAsync("sticker", pSticker);
        }

        

        
        Panel_Color_Bubble pn_Color_Bubble = new Panel_Color_Bubble();

        private void Button_More_Click(object sender, EventArgs e)
        {
            Panel_Color_Bubble.NotifyChangeColor = new Notify(this.notifyChangeColor);
            pn_Color_Bubble.Show();
        }

        private void TimeRequest_Tick(object sender, EventArgs e)
        {
            TimeRequest.Stop();
            GetMessageAsync();

        }

        private void Button_Picture_Click(object sender, EventArgs e)
        {
            FileUpload fu = new FileUpload(App_Status.urlUpload, id_conversation, "image");
            if (fu.UploadFile("image"))
            {
                addInMessage(User_Info.k_ID, "", "localImage", fu.FilePath, "");
            }
        }
    }
}
