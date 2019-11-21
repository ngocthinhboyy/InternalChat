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
    public partial class bubble : UserControl
    {
        private string kMessage;
        private string urlPic;
        private string urlSticker;
        private int Mess_Type;
        private string kTime;
        private msgType messageType;


        public bubble()
        {
            InitializeComponent();
        }

        int isPicture = 0;

        public bubble(string kMessage, string urlPic, string urlSticker, int Mess_Type, string kTime, msgType messageType)
        {

            InitializeComponent();
            // Define
            this.kMessage = kMessage;
            this.urlPic = urlPic;
            this.urlSticker = urlSticker;
            this.Mess_Type = Mess_Type;
            this.kTime = kTime;
            this.messageType = messageType;



            lb_message.Text = kMessage;
            if (urlSticker == "")
            {
                this.Width = lb_message.Width + 20;
            }
            else
            {
                this.Width = picture_sticker.Width + 20;
            }

            lb_message.Top = 10;
            lb_message.Left = 10;
            lb_time.Text = kTime;
            SetHeight();
            ChangeColorBubble();
            if (urlSticker != "")
            {
                isPicture = 1;
                gradientPanel.Visible = false;
                this.BackColor = Color.Transparent;
                picture_sticker.ImageLocation = "../../Resources\\" + urlSticker;
                picture_sticker.Visible = true;
            }
            /*SetHeight(isPicture);*/
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

                lb_time.Top = picture_sticker.Bottom + 10;
                this.Height = picture_sticker.Bottom + 10;
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
            if (this.messageType.ToString() == "In")
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
