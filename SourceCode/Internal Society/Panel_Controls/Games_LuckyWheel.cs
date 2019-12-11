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
using Newtonsoft.Json;

namespace Internal_Society
{
    public delegate void ChangeKey();
    public partial class Games_LuckyWheel : UserControl
    {
        public static ChangeKey delegatechangeKeyGame;
        public static ChangeKey delegatechangeGame;
        string kMessage = "";
        int kIndex = 1;
        int kTarget = 0;
        Color cFocus = Color.Gainsboro;
        public void defualPanel()
        {
            Slot_1.BackColor = Color.Transparent;
            Slot_2.BackColor = Color.Transparent;
            Slot_3.BackColor = Color.Transparent;
            Slot_4.BackColor = Color.Transparent;
            Slot_5.BackColor = Color.Transparent;
            Slot_6.BackColor = Color.Transparent;
            Slot_7.BackColor = Color.Transparent;
            Slot_8.BackColor = Color.Transparent;
            

        }
        public Games_LuckyWheel()
        {
            InitializeComponent();
        }


        public async void Play()
        {
            try
            {
                var urlGetData = App_Status.urlAPI + "c_LuckyWheel/Play/" + User_Info.k_ID;
                Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlGetData); });
                // await
                string result = await getStringTask;
                dynamic data = JsonConvert.DeserializeObject(result);
                if(Convert.ToBoolean(data.success.ToString()) == true)
                {
                    DangQuay();
                    kTarget = 9 - kIndex + 8 * 6 + Convert.ToInt32(data.index);
                    kMessage = data.message.ToString();
                }
                else
                {
                    MacDinh();
                    MessageBox.Show("You don't have enough key to play !");
                }
                
            }
            catch
            {
                MessageBox.Show("Connection Error");
            }

        }

        private void loading()
        {
            button_play.Enabled = false;
            button_play.Text = "...";
        }

        private void DangQuay()
        {
            button_play.Enabled = false;
            button_play.Text = "...";
            timer1.Start();
        }

        private async void QuayXong()
        {
            button_play.Enabled = true;
            button_play.Text = "Play";
            MessageBox.Show(kMessage);
            string urlRequest = App_Status.urlAPI + "c_User/GetUserInfo/" + User_Info.k_ID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });

            // await
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            User_Info.k_Gold = data.Gold;
            User_Info.k_Diamond = data.Diamond;
            User_Info.k_LuckyWheel = data.LuckyKey;
            delegatechangeGame();
        }

        private void MacDinh()
        {
            button_play.Enabled = true;
            button_play.Text = "Play";
            
        }

        private async void Button_play_Click(object sender, EventArgs e)
        {
            loading();
            delegatechangeKeyGame();
            Play();
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (kIndex > 8) kIndex = 1;
            if(kTarget < 1) {
                timer1.Stop();
                QuayXong();
                return;
            }
            defualPanel();
            if (kIndex == 1) Slot_1.BackColor = cFocus;
            else if (kIndex == 2) Slot_2.BackColor = cFocus;
            else if (kIndex == 3) Slot_3.BackColor = cFocus;
            else if (kIndex == 4) Slot_4.BackColor = cFocus;
            else if (kIndex == 5) Slot_5.BackColor = cFocus;
            else if (kIndex == 6) Slot_6.BackColor = cFocus;
            else if (kIndex == 7) Slot_7.BackColor = cFocus;
            else if (kIndex == 8) Slot_8.BackColor = cFocus;
            kTarget--;
            kIndex++;
        }
    }
}
