using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using System.IO;
using System.Diagnostics;

namespace Internal_Society
{
    public partial class bubble : UserControl
    {
        private string user_ID;
        private string message_ID;
        private string message_Type;
        private string message_Detail;
        private string message_Time;
        private string urlImage;
        private msgType InOrOut;


        public bubble()
        {
            InitializeComponent();
        }

        int isPicture = 0;

        public bubble(string user_ID, string message_ID, string message_Type,
            string message_Detail, string message_Time, msgType InOrOut)
        {

            InitializeComponent();
            #region Define
            this.user_ID = user_ID;
            this.message_ID = message_ID;
            this.message_Type = message_Type;
            this.message_Detail = message_Detail;
            this.message_Time = message_Time;
            this.InOrOut = InOrOut;
            #endregion


            lb_message.Text = message_Detail.ToString();
            if (message_Type == "otherFile" || message_Type == "otherLocalFile")
            {
                lb_message.Text = "<< Click to see attachment >>";
                lb_message.Cursor = Cursors.Hand;
                lb_message.Click += ViewOtherFile;
                message_Type = "text";
            }
            

            if (message_Type == "text")
            {
                this.Width = lb_message.Width + 20;
            }
            else
            {
                this.Width = picture_sticker.Width + 20;
            }

            lb_message.Top = 10;
            lb_message.Left = 10;
            ChangeColorBubble();
            lb_time.Text = message_Time;
            SetHeight();
            ChangeColorBubble();

            

            if (message_Type != "text")
            {
                isPicture = 1;
                gradientPanel.Visible = false;
                picture_sticker.Visible = true;
                this.BackColor = Color.Transparent;
                if (message_Type == "sticker")
                {
                    this.urlImage = App_Status.urlLocalResources + message_Detail;
                    picture_sticker.ImageLocation = this.urlImage;
                }
                else if (message_Type == "image")
                {
                    this.urlImage = App_Status.urlImage + "/" + message_Type + "/" + message_Detail;
                    picture_sticker.ImageLocation = this.urlImage;
                    picture_sticker.Cursor = Cursors.Hand;
                    picture_sticker.Click += ViewImage;
                }
                else if (message_Type == "localImage")
                {
                    urlImage = message_Detail;
                    picture_sticker.ImageLocation = urlImage;
                    picture_sticker.Cursor = Cursors.Hand;
                    picture_sticker.Click += ViewImage;
                }
               
            }
            /*SetHeight(isPicture);*/
        }

        void ViewImage(object sender, EventArgs e)
        {
            fileView fV = new fileView(this.urlImage);
            fV.Show();
        }

        void ViewOtherFile(object sender, EventArgs e)
        {

            System.IO.Directory.CreateDirectory("Download");
            string fileName = "";
            if (message_Type == "otherLocalFile")
            {
                fileName = message_Detail;
            }
            else
            {
                HttpRequest http = new HttpRequest();
                http.ConnectTimeout = 99999999;
                http.KeepAliveTimeout = 99999999;
                http.ReadWriteTimeout = 99999999;

                string urlFile = MaHoa.EncryptDecrypt2(message_Detail.ToString(), App_Status.keyKun);
                var binImg = http.Get("https://kunbr0.com/it008b/c_View/file/3/" + urlFile).ToMemoryStream().ToArray();

                fileName = "Download\\" + urlFile + ".txt";

                File.WriteAllBytes(fileName, binImg);
            }
            

            Process.Start(fileName);
        }


        //lets add the function 

        void SetHeight()
        {
            //Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();


            if (isPicture == 0)
            {
                SizeF size = g.MeasureString(lb_message.Text, lb_message.Font, lb_message.Width);
                lb_message.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());

                //lb_time.Top = lb_message.Bottom + 10;
                this.Height = lb_message.Height + 20;
                //this.Width = lb_message.Width + 20;
                //picture_sticker.Visible = false;
            }
            if (isPicture == 1)
            {
               // picture_sticker.Top = -10;
                
                this.Height = picture_sticker.Bottom;
                //this.Width = picture_sticker.Width + 20;
                //picture_sticker.Visible = true;
            }


        }

        private void Bubble_Resize(object sender, EventArgs e)
        {

            if (picture_sticker.ImageLocation == null)
            {
                SetHeight();
            }
            else
            {
                SetHeight();
            }

        }

        public void ChangeColorBubble()
        {
            if (this.InOrOut.ToString() == "In")
            {
                // Incoming message
                //this.BackColor = Color.FromArgb(0, 164, 147);
                gradientPanel.GradientBottomLeft = gradientPanel.GradientTopLeft = Panel_Color_Bubble.LeftColor;
                gradientPanel.GradientBottomRight = gradientPanel.GradientTopRight = Panel_Color_Bubble.RightColor;

                lb_message.TextAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                // Message from me
                //this.BackColor = Color.Gray;
                gradientPanel.GradientBottomLeft = gradientPanel.GradientTopLeft =
                gradientPanel.GradientBottomRight = gradientPanel.GradientTopRight = Color.FromArgb(241, 240, 240);
                lb_message.TextAlign = ContentAlignment.MiddleLeft;
                lb_message.ForeColor = Color.Black;
            }
        }
    }

    public enum msgType
    {
        In,
        Out
    }
}
