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

namespace Internal_Society
{
    

    public partial class chatbox : UserControl
    {
        const string urlKun = "../../Resources\\";
        
        
        string id_user = "1";
        string id_counterpart = "2";
        string json;
        public chatbox()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
                panel2.Controls.RemoveAt(0);
                panel2.Controls.RemoveAt(0);
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


        bubble bbl_old = new bubble();

        
        

        public void addInMessage(string kkMessage, string kkTime, string urlPic)
        {
            

            bubble bbl = new Internal_Society.bubble(kkMessage,kkTime,msgType.In,urlPic);
            bbl.Location = bubble1.Location;
            bbl.Size = bubble1.Size;
            bbl.Font = bubble1.Font;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 20;


            
            panel2.Controls.Add(bbl);
            
            
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
            bbl_old = bbl;


            /*StreamWriter kWrite = new StreamWriter("conversation_5.txt",true);
            string inputTime = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
            string inputFile = "{\"ID\":\"" + id_user +"\",\"Message_Data\":\""+ txt_input.Text+ "\",\"Time_Data\":\"" + inputTime+"\"}";
            kWrite.WriteLine(inputFile);
            kWrite.Close();*/


        }

        public void addOutMessage(string kkMessage, string kkTime, string urlPic)
        {
            
            bubble bbl = new Internal_Society.bubble(kkMessage, kkTime, msgType.Out,urlPic);
            bbl.Location = bubble2.Location; 
            bbl.Size = bubble1.Size;
            
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 20;

            
            
            panel2.Controls.Add(bbl);
            bbl_old = bbl;


        }

        
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            json = "";
            string urlPic = "";
            string kInput = txt_input.Text.ToString();

            ThreadStart ts_1 = new ThreadStart(GetData);
            Thread thrd_1 = new Thread(ts_1);
            thrd_1.Start();
            

            StreamWriter kWrite = new StreamWriter("conversation_5.txt", true);
            string inputTime = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
            string urlPicture = "heohong_001.png";
            string inputFile = "{\"ID\":\"" + id_user + "\",\"Message_Data\":\"" + txt_input.Text + "\",\"Time_Data\":\"" + inputTime + "\",\"urlPic\":\"" + urlPicture + "\"}";
            kWrite.WriteLine(inputFile);
            kWrite.Close();

            addInMessage(kInput, inputTime, urlPic);

            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;

            

            txt_input.Text = json;
        }

        void GetData()
        {
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://kunbr0.com/it008/login.php?us=toantan&ps=789789");
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BunifuImageButton1_Click(this, new EventArgs());
            }

            if (e.KeyCode == Keys.Q)
            {
                
                int heightInsert = 50;

                foreach (Control kMessage in panel2.Controls)
                {
                    kMessage.Top += heightInsert; 

                }
                MessageBox.Show(panel2.Controls.Count.ToString());
            }

            
            
        }
    }
}
