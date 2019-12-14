using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Society
{
    public delegate void ChangeDiamond();
    public partial class BuyKey : Form
    {
        public static ChangeDiamond delegateChangeDiamondGame;
        public static ChangeDiamond delegateChangeDiamondCart;
        public static ChangeDiamond delegateChangeDiamondFrmGame;
        private bool mouseDown;
        private Point lastLocation;
        public BuyKey()
        {
            InitializeComponent();
            lb_Diamond.Text = User_Info.k_Diamond;
            lb_KeyWheel.Text = User_Info.k_LuckyWheel;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (lb_quantityKey.Text == "0")
                subtract.Enabled = false;
            else
            {
                subtract.Enabled = true;
                int number = Convert.ToInt32(lb_quantityKey.Text);
                number--;
                lb_quantityKey.Text = number.ToString();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(lb_quantityKey.Text);
            number++;
            lb_quantityKey.Text = number.ToString();
        }

        private async void BtnPurchase_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(lb_quantityKey.Text);
            if (number * 5 > Convert.ToInt32(lb_Diamond.Text) || Convert.ToInt32(lb_Diamond.Text) == 0)
            {
                IncorrectAlert alert = new IncorrectAlert("You don't have enough gems");
                alert.Show();
            }
            else
            {
                string urlRequest = App_Status.urlAPI + "c_LuckyWheel/BuyKey/" + User_Info.k_ID + "/" + lb_quantityKey.Text;
                Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });


                // await
                string result = await getStringTask;
                dynamic data = JsonConvert.DeserializeObject(result);
                if (data.Success == "1")
                {
                    string urlRequest1 = App_Status.urlAPI + "c_User/GetUserInfo/" + User_Info.k_ID;
                    Task<string> getStringTask1 = Task.Run(() => { return new WebClient().DownloadString(urlRequest1); });

                    // await
                    string result1 = await getStringTask1;
                    dynamic data1 = JsonConvert.DeserializeObject(result1);
                    User_Info.k_Diamond = data1.Diamond;
                    User_Info.k_LuckyWheel = data1.LuckyKey;
                    lb_Diamond.Text = User_Info.k_Diamond;
                    lb_KeyWheel.Text = User_Info.k_LuckyWheel;
                    delegateChangeDiamondGame();
                    delegateChangeDiamondCart();
                    if(delegateChangeDiamondFrmGame != null)
                        delegateChangeDiamondFrmGame();
                    IncorrectAlert alert = new IncorrectAlert("Buy Successfully.");
                    alert.Show();
                }
                else
                {
                    if(number == 0 )
                    {
                        IncorrectAlert alert = new IncorrectAlert("Please choose the number of gems.");
                        alert.Show();
                    }
                    else
                    {
                        IncorrectAlert alert = new IncorrectAlert("You must have more than 5 gems to purchase.");
                        alert.Show();
                    }
                }
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BuyKey_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void BuyKey_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BuyKey_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
