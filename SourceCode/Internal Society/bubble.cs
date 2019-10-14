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
        public bubble()
        {
            InitializeComponent();
        }

        

        public bubble(string kMessage, string kTime, msgType messageType, string urlPic)
        {
            InitializeComponent();
            lb_message.Text = kMessage;
            lb_time.Text = kTime;
            if(messageType.ToString() == "In")
            {
                // Incoming message
                this.BackColor = Color.FromArgb(0, 164, 147);
            }
            else
            {
                // Message from me
                this.BackColor = Color.Gray;
            }
            /*int isPicture = 0;*/
            if (urlPic != "")
            {
                /*isPicture = 1;*/

                picture_sticker.ImageLocation = urlPic;
            }

            /*SetHeight(isPicture);*/
        }

        

            //lets add the function 

            void SetHeight(int isPicture)
            {
                Size maxSize = new Size(495, int.MaxValue);
                Graphics g = CreateGraphics();
                
                
            if(isPicture == 0)
            {
                SizeF size = g.MeasureString(lb_message.Text, lb_message.Font, lb_message.Width);
                lb_message.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
                lb_time.Top = lb_message.Bottom + 10;
                picture_sticker.Visible = false;
            }
            if(isPicture == 1)
            {
                
                lb_time.Top = picture_sticker.Bottom + 10;
                picture_sticker.Visible = true;
            }

            this.Height = lb_time.Bottom + 10;
            }

        private void Bubble_Resize(object sender, EventArgs e)
        {

            if(picture_sticker.ImageLocation == null)
            {
                SetHeight(0);
            }
            else
            {
                SetHeight(1);
            }
            
        }
    }

    public enum msgType
    {
        In,
        Out
    }
}
