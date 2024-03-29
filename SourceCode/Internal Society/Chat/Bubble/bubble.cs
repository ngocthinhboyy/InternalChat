﻿using System;
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
        private Color kLeftColor = Color.FromArgb(0, 132, 255);
        private Color kRightColor = Color.FromArgb(0, 132, 255);

        public bubble()
        {
            InitializeComponent();
        }

        int isPicture = 0;

        public bubble(string user_ID, string message_ID, string message_Type,
            string message_Detail, string message_Time, msgType InOrOut, Color kLeft, Color kRight)
        {

            InitializeComponent();
            #region Define
            this.user_ID = user_ID;
            this.message_ID = message_ID;
            this.message_Type = message_Type;
            this.message_Detail = message_Detail;
            this.message_Time = message_Time;
            this.InOrOut = InOrOut;
            this.kLeftColor = kLeft;
            this.kRightColor = kRight;
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
        void SetHeight()
        {
            Graphics g = CreateGraphics();


            if (isPicture == 0)
            {
                SizeF size = g.MeasureString(lb_message.Text, lb_message.Font, lb_message.Width);
                lb_message.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
                this.Height = lb_message.Height + 20;
            }
            if (isPicture == 1)
            {
                this.Height = picture_sticker.Bottom;
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

        public void ChangeColorBubble(Color a, Color b)
        {
            this.kLeftColor = a;
            this.kRightColor = b;
            this.ChangeColorBubble();
        }

        public void ChangeColorBubble()
        {
            if (this.InOrOut.ToString() == "In")
            {
                gradientPanel.GradientBottomLeft = gradientPanel.GradientTopLeft = kLeftColor;
                gradientPanel.GradientBottomRight = gradientPanel.GradientTopRight = kRightColor;
                lb_message.TextAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
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
