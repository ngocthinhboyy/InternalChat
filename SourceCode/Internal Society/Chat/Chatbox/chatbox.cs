using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
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
        public Color kLeftColor = Color.FromArgb(0, 132, 255);
        public Color kRightColor = Color.FromArgb(0, 132, 255);
        int messIndex = 0;
        bool isReceiveFromMe = true;
        private static int sequenceSticker = -1;
        Internal_Society.loading loading = new Internal_Society.loading();
        public static readonly HttpClient client = new HttpClient();

        #endregion
        public chatbox()
        {

        }
        public chatbox(int conversation_id, int ColorID)
        {
            id_conversation = conversation_id.ToString();
            switch (ColorID)
            {
                case 0:
                    break;
                case 1:
                    this.kLeftColor = ColorData.Color_Left_1;
                    this.kRightColor = ColorData.Color_Right_1;
                    break;
                case 2:
                    this.kLeftColor = ColorData.Color_Left_2;
                    this.kRightColor = ColorData.Color_Right_2;
                    break;
                case 3:
                    this.kLeftColor = ColorData.Color_Left_3;
                    this.kRightColor = ColorData.Color_Right_3;
                    break;
                case 4:
                    this.kLeftColor = ColorData.Color_Left_4;
                    this.kRightColor = ColorData.Color_Right_4;
                    break;
                case 5:
                    this.kLeftColor = ColorData.Color_Left_5;
                    this.kRightColor = ColorData.Color_Right_5;
                    break;
                case 6:
                    this.kLeftColor = ColorData.Color_Left_6;
                    this.kRightColor = ColorData.Color_Right_6;
                    break;
                case 7:
                    this.kLeftColor = ColorData.Color_Left_7;
                    this.kRightColor = ColorData.Color_Right_7;
                    break;
                case 8:
                    this.kLeftColor = ColorData.Color_Left_8;
                    this.kRightColor = ColorData.Color_Right_8;
                    break;
                case 9:
                    this.kLeftColor = ColorData.Color_Left_9;
                    this.kRightColor = ColorData.Color_Right_9;
                    break;
                case 10:
                    this.kLeftColor = ColorData.Color_Left_10;
                    this.kRightColor = ColorData.Color_Right_10;
                    break;
                case 11:
                    this.kLeftColor = ColorData.Color_Left_11;
                    this.kRightColor = ColorData.Color_Right_11;
                    break;
                case 12:
                    this.kLeftColor = ColorData.Color_Left_12;
                    this.kRightColor = ColorData.Color_Right_12;
                    break;


            }
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
            bbl_old.Top = 0 - bbl_old.Height + 10;
            loading.Location = new Point(this.Width / 2 - 50, 100);
            panel2.Controls.Add(loading);

        }

        public void SetColor(Color a, Color b, int colorID)
        {
            this.kLeftColor = a;
            this.kRightColor = b;
            ChangeColorConversation(colorID);
            notifyChangeColor();
        }


        public async void ChangeColorConversation(int colorID)
        {
            try
            {
                var urlGetData = App_Status.urlAPI + "c_Message/ChangeColor/" + this.id_conversation + "/"
                    + User_Info.k_ID + "/" + colorID;
                Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlGetData); });
                // await
                string result = await getStringTask;
                
            }
            catch
            {
                IncorrectAlert alert = new IncorrectAlert("Connection Error");
                alert.Show();
            }

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
                    ((bubble)x).ChangeColorBubble(kLeftColor,kRightColor);

                }
            }
        }

        public void addInMessage(string user_ID, string message_ID, string message_Type,
            string message_Detail, string message_Time)
        {
            bubble bbl = new Internal_Society.bubble(user_ID, message_ID, message_Type,
             message_Detail, message_Time, msgType.In, this.kLeftColor, this.kRightColor);
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
        }

        public void addOutMessage(string user_ID, string message_ID, string message_Type,
            string message_Detail, string message_Time)
        {

            bubble bbl = new Internal_Society.bubble(user_ID, message_ID, message_Type,
             message_Detail, message_Time, msgType.Out, this.kLeftColor, this.kRightColor);
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
            if (!dMess.success)
            {
                isReceiveFromMe = false;
                return;
            }
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
                IncorrectAlert alert = new IncorrectAlert("Connection Error");
                alert.Show();
            }

        }




        private void Button_Attach_Click(object sender, EventArgs e)
        {
            FileUpload fu = new FileUpload(App_Status.urlUpload, id_conversation, "otherFile");
            if (fu.UploadFile("otherFile"))
            {
                addInMessage(User_Info.k_ID, "", "otherLocalFile", fu.FilePath, "");
            }
        }

        Panel_Sticker pn_Sticker = new Panel_Sticker(true);
        private void Button_Sticker_Click(object sender, EventArgs e)
        {
            Panel_Sticker.ExecuteDelegate = AddSticker;

            if (!pn_Sticker.IsDisposed)
            {
                if (sequenceSticker != ListSticker.Sequence)
                {
                    pn_Sticker.Close();
                    pn_Sticker = new Panel_Sticker(true);
                }
                pn_Sticker.Show();
            }
            else
            {
                pn_Sticker = new Panel_Sticker(true);
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
            Panel_Color_Bubble.SetColor = new Notify(SetColor);
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
