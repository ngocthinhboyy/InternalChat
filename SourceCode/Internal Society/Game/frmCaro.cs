using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace Internal_Society
{
    public partial class frmCaro : Form
    {
        Graphics g;
        Caro_Chess caro_chess = new Caro_Chess();
        int myUserID = Convert.ToInt32(User_Info.k_ID);
        int friendUserID = -1;
        string friendUserName = "";
        private bool mouseDown;
        private Point lastLocation;
        int myGameID = -1;
        bool isMyUserTurnInOnline = true;
        private static int MarginBottomOfFriend = 20;
        List<int> ListIDOnline = new List<int>();
        public frmCaro()
        {
            InitializeComponent();
            g = pnl.CreateGraphics();
            string sLuatChoi = "- Hai bên lần lượt đánh vào\n từng ô.\n- Bên nào đạt 5 con trên 1\n hàng ngang, hàng dọc, chéo\n xuôi, chéo ngược mà không\n bị chặn 2 đầu là người chiến\n thắng. \n- Nếu bàn cờ đầy thì hòa cờ .";
            lblLuatChoi.Text = sLuatChoi;
        }

        private void Pnl_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caro_chess.BIsPlaying)
                return;
            if (caro_chess.IGameMode == 2)
            {
                if (isMyUserTurnInOnline == true)
                {
                    caro_chess.XacDinhVeOCo(e.X, e.Y, g);
                    int iIndexOnline = caro_chess.LCacNuocDaDi.Count() - 1;
                    O_Co oCoCuoiCung = caro_chess.LCacNuocDaDi.ElementAt<O_Co>(iIndexOnline);
                    int iDong = oCoCuoiCung.IDong;
                    int iCot = oCoCuoiCung.ICot;
                    int iSohuu = oCoCuoiCung.ISo_Huu - 1;
                    string sQuanCo = iCot.ToString() + "a" + iDong.ToString() + "b" + iSohuu.ToString();
                    guiDataLenDB(myGameID, iIndexOnline, sQuanCo);
                    isMyUserTurnInOnline = false;
                }
                return;
            }
            if(caro_chess.IGameMode == 1)
            {
                caro_chess.XacDinhVeOCo(e.X, e.Y, g);
            }
            if (caro_chess.KiemTraChienThang() && caro_chess.IGameMode == 1)
            {
                caro_chess.EndgameOffline();
                caro_chess.BIsPlaying = false;
                return;
            }
        }
        public async void guiDataLenDB(int idGameCo, int index, string sQuanCo)
        {
            string urlRequest = "https://kunbr0.com/kunbr0/add_data.php?game_id=" + idGameCo + "&user_id=" + myUserID + "&index=" + index + "&data=" + sQuanCo;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            //iStatus = Convert.ToInt32(data.status.ToString());
        }

        private void Pnl_Paint(object sender, PaintEventArgs e)
        {
            caro_chess.KiemTraVeLai(g);
        }
        /*
private void BtnNewGame_Click(object sender, EventArgs e)
{
if (caro_chess.IGameMode == 0)
{
MessageBox.Show("Chưa chọn chế độ chơi !", "Lỗi");
return;
}
if (caro_chess.IGameMode == 1)
{
// play Offline
caro_chess.BIsPlaying = true;
g.Clear(pnl.BackColor);
caro_chess.VeBanCo(g);
caro_chess.TaoMangOCo();
caro_chess.StartPlayOffline();
}
else
{
// play Online
MessageBox.Show(User_Info.k_ID.ToString());
//CreateNewGameOnline(User_Info.k_ID)
caro_chess.BIsPlaying = true;
g.Clear(pnl.BackColor);
caro_chess.VeBanCo(g);
caro_chess.TaoMangOCo();
caro_chess.StartPlayOnline();
}
}
private void BtnThoat_Click(object sender, EventArgs e)
{
this.Close();
private void BtnPlayOffline_Click(object sender, EventArgs e)
{
caro_chess.BIsPlaying = true;
g.Clear(pnl.BackColor);
caro_chess.VeBanCo(g);
caro_chess.TaoMangOCo();
caro_chess.StartPlayOffline();
}

private void BtnPlayOnline_Click(object sender, EventArgs e)
{
MessageBox.Show(User_Info.k_ID.ToString());
caro_chess.BIsPlaying = true;
g.Clear(pnl.BackColor);
caro_chess.VeBanCo(g);
caro_chess.TaoMangOCo();
timer_Load.Enabled = true;
timer_Load.Start();
caro_chess.StartPlayOnline();
caro_chess.GetDataFromDBWithGameID(g, 41);
}
}*/
        public async void getDataChess(int id)
        {
            timer_Load.Stop();
            string urlRequest = "https://kunbr0.com/kunbr0/get_data.php?game_id=" + id;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            string newestData = data.data.ToString();
            string turnID = data.turn.ToString();
            if (newestData != caro_chess.PreviousData && newestData != "" && newestData != null)
            {
                caro_chess.PreviousData = newestData;
                int turnIDOnline = Convert.ToInt32(turnID);
                if (turnIDOnline == myUserID)
                    isMyUserTurnInOnline = true;
                else
                    isMyUserTurnInOnline = false;
                xuLyVe1QuanCo(newestData, Convert.ToInt32(turnID));
            }
            timer_Load.Start();
        }
        public void xuLyVe1QuanCo(string chessArr, int turnID)
        {
            string[] splitrawString = { "a", "b", "," };
            string[] listNumber = chessArr.Split(splitrawString, StringSplitOptions.RemoveEmptyEntries);
            int[] arrInt = new int[1200];
            int i = 0;
            int iCot = 0;
            int iDong = 0;
            List<O_Co> lCacNuocDaDi = new List<O_Co>();
            foreach (string s in listNumber)
            {
                arrInt[i] = Convert.ToInt32(s);
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                iCot = arrInt[j];
                iDong = arrInt[j + 1];
                caro_chess.MMang_O_Co[iDong, iCot].ISo_Huu = arrInt[j + 2] + 1;
                lCacNuocDaDi.Add(caro_chess.MMang_O_Co[iDong, iCot]);
                j = j + 2;
            }
            caro_chess.LCacNuocDaDi.RemoveRange(0, caro_chess.LCacNuocDaDi.Count());
            foreach (O_Co x in lCacNuocDaDi)
                caro_chess.LCacNuocDaDi.Add(x);
            caro_chess.XacDinhVeOCoSauKhiCoThayDoiTuDB(iDong, iCot, g);
            if (caro_chess.KiemTraChienThang())
            {
                caro_chess.EndgameOnline(friendUserName);
                if (turnID != myUserID)
                    caro_chess.BIsPlaying = false;
                else
                    caro_chess.BIsPlaying = true;
                return;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (myGameID != -1)
            {
                timer_Load.Stop();
                getDataChess(myGameID);
            }
        }
        private async void CreateNewGameOnline(int idUser1, int idUser2)
        {
            string urlRequest = "https://kunbr0.com/kunbr0/create_game.php?user_1=" + idUser1 + "&user_2=" + idUser2 + "&whoseTurn=" + idUser1;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            myGameID = Convert.ToInt32(data.id.ToString());
            caro_chess.GetDataFromDBWithGameID(g, myGameID);
        }

        private void BtnPlayOnline1_Click(object sender, EventArgs e)
        {
            CreateNewGameOnline(myUserID, 1);
            caro_chess.BIsPlaying = true;
            g.Clear(pnl.BackColor);
            caro_chess.VeBanCo(g);
            caro_chess.TaoMangOCo();
            timer_Load.Enabled = true;
            caro_chess.StartPlayOnline();
            btnPlayOnline1.Enabled = false;
            btnPlayOffline1.Enabled = true;
            btnChoiMoi1.Enabled = true;
        }

        private void BtnPlayOffline1_Click(object sender, EventArgs e)
        {
            caro_chess.BIsPlaying = true;
            g.Clear(pnl.BackColor);
            caro_chess.VeBanCo(g);
            caro_chess.TaoMangOCo();
            caro_chess.StartPlayOffline();
            btnPlayOffline1.Enabled = false;
            btnPlayOnline1.Enabled = true;
            btnChoiMoi1.Enabled = true;
        }

        private void BtnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChoiMoi1_Click(object sender, EventArgs e)
        {
            if (caro_chess.IGameMode == 0)
            {
                MessageBox.Show("Chưa chọn chế độ chơi !", "Lỗi");
                return;
            }
            if (caro_chess.IGameMode == 1)
            {
                // play Offline
                caro_chess.BIsPlaying = true;
                g.Clear(pnl.BackColor);
                caro_chess.TaoMangOCo();
                caro_chess.VeBanCo(g);
                caro_chess.StartPlayOffline();
                btnChoiMoi1.Enabled = true;
            }
            else
            {
                // play Online
                CreateNewGameOnline(myUserID, 1);
                caro_chess.BIsPlaying = true;
                g.Clear(pnl.BackColor);
                caro_chess.TaoMangOCo();
                caro_chess.VeBanCo(g);
                caro_chess.StartPlayOnline();
                btnChoiMoi1.Enabled = true;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            caro_chess.BIsPlaying = false;
            g.Clear(pnl.BackColor);
            caro_chess.VeBanCo(g);
            caro_chess.IGameMode = 0;
            btnPlayOnline1.Enabled = true;
            btnPlayOffline1.Enabled = true;
            btnChoiMoi1.Enabled = false;
        }

        private void FrmCaro_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FrmCaro_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void FrmCaro_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void BtnPlayOffline1_Click_1(object sender, EventArgs e)
        {
            caro_chess.BIsPlaying = true;
            g.Clear(pnl.BackColor);
            caro_chess.VeBanCo(g);
            caro_chess.TaoMangOCo();
            caro_chess.StartPlayOffline();
            btnPlayOnline1.ButtonText = "Chơi với bạn bè";
            btnPlayOffline1.Enabled = false;
            btnPlayOnline1.Enabled = true;
            btnChoiMoi1.Enabled = true;
        }
        string listUsers = "";
        public async void GetDataAsync()
        {
            string urlSearchUser = App_Status.urlAPI + "c_Friend/Get_FriendList/" + User_Info.k_ID;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlSearchUser); });
            // await
            string result = await getStringTask;
            listUsers = result;
            ShowOnlineUser();
            
        }
        bool isExist(List<int> kList, int a)
        {
            foreach (int item in kList)
            {
                if (item == a) return true;
            }
            return false;
        }
        public void ShowOnlineUser()
        {
            //label_NoActiveFriend.Visible = false;
            List<int> ProcessedFriend = new List<int>();

            if (listUsers == "") return;
            ListUserOnline userArr = new JavaScriptSerializer().Deserialize<ListUserOnline>(listUsers);


            if (!userArr.success)
            {
                pnl_Friend.Controls.Clear();
                pnl_Friend.Controls.Add(label_NoActiveFriend);
                label_NoActiveFriend.Visible = true;
                return;
            }


            if (userArr.data.Count() > 0)
            {
                friend friend_last = new friend("", "", "", 0);

                friend_last.Top = 0 - friend_last.Height + 10;
                foreach (Control kk in this.Controls)
                {
                    if (kk is friend)
                    {
                        friend aF = kk as friend;
                        friend_last = aF;
                    }
                }
                for (int i = 0; i < userArr.data.Count(); i++)
                {
                    if (isExist(ListIDOnline, Convert.ToInt32(userArr.data[i].friend_Conversation_ID)))
                    {
                        foreach (var item in this.Controls)
                        {
                            if (item is friend)
                            {
                                friend aFriend = item as friend;
                                aFriend.Width = 200;
                                if (Convert.ToInt32(aFriend.Tag) == Convert.ToInt32(userArr.data[i].friend_Conversation_ID))
                                {
                                    aFriend.UpdateFriend(userArr.data[i].friend_Avatar, userArr.data[i].friend_Username, userArr.data[i].friend_Fullname,
                            userArr.data[i].friend_lastLogin);
                                    ProcessedFriend.Add(userArr.data[i].friend_Conversation_ID);

                                    break;

                                }
                            }

                        }

                    }

                    else
                    {

                        ListIDOnline.Add(Convert.ToInt32(userArr.data[i].friend_Conversation_ID));
                        friend friend = new friend(userArr.data[i].friend_Avatar, userArr.data[i].friend_Username, userArr.data[i].friend_Fullname,
                            userArr.data[i].friend_lastLogin);
                        friend.Location = new Point(10, 0);
                        friend.Top = friend_last.Bottom + MarginBottomOfFriend;

                        friend.Width = 200;
                        friend.Tag = userArr.data[i].friend_ID.ToString();

                        //friend.MouseEnter += Friend_Enter;
                        //friend.Click += Friend_Click;
                        //friend.MouseEnter += Friend_MouseEnter;
                        friend.Click += Friend_Click;
                        friend.MouseEnter += Friend_MouseEnter1;

                        pnl_Friend.Controls.Add(friend);
                        //this.VerticalScroll.Value = this.VerticalScroll.Maximum;
                        //this.VerticalScroll.Visible = false;
                        friend_last = friend;
                        //ProcessedFriend.Add(userArr.data[i].friend_Conversation_ID);
                    }
                }


            }

            //for (int i = 0; i < ListIDOnline.Count; i++)
            //{
            //    if (!isExist(ProcessedFriend, ListIDOnline[i]))
            //    {
            //        RemoveFriendFromUserID(ListIDOnline[i]);
            //        //MessageBox.Show("remove");
            //    }
            //}


           // CopyListToList(ProcessedFriend, ListIDOnline);
        }

        private void Friend_MouseEnter1(object sender, EventArgs e)
        {
            Internal_Society.friend atf = sender as Internal_Society.friend;
            if (atf != null && atf.BackColor != Color.FromArgb(App_Status.RedTabChat, App_Status.GreenTabChat, App_Status.BlueTabChat))
                atf.BackColor = Color.FromArgb(App_Status.backFormColor.R - 10, App_Status.backFormColor.G - 10, App_Status.backFormColor.B - 10);
        }

        private void Friend_Click(object sender, EventArgs e)
        {
            if(sender is friend)
            {

                friend fr = sender as friend;
                friendUserID =  Convert.ToInt32(fr.Tag.ToString());
                friendUserName = fr.userName;
                bunifuTransition1.HideSync(pnl_Friend);
                pnlGameCaro.Location = new Point(0, 0);
                bunifuTransition2.ShowSync(pnlGameCaro);
                pnlGameCaro.Dock = DockStyle.Left;
                CreateNewGameOnline(myUserID, friendUserID);
                caro_chess.BIsPlaying = true;
                g.Clear(pnl.BackColor);
                caro_chess.VeBanCo(g);
                caro_chess.TaoMangOCo();
                timer_Load.Enabled = true;
                caro_chess.StartPlayOnline();
                btnPlayOnline1.ButtonText = "Chơi với " + friendUserName;
                btnPlayOnline1.Enabled = false;
                btnPlayOffline1.Enabled = true;
                btnChoiMoi1.Enabled = true;
                //pnlGameCaro.Width = 30;
            }
        }

        private void Friend_MouseEnter(object sender, EventArgs e)
        {
            Internal_Society.friend atf = sender as Internal_Society.friend;
            if (atf != null && atf.BackColor != Color.FromArgb(App_Status.RedTabChat, App_Status.GreenTabChat, App_Status.BlueTabChat))
                atf.BackColor = Color.FromArgb(App_Status.backFormColor.R - 10, App_Status.backFormColor.G - 10, App_Status.backFormColor.B - 10);
            else
                atf.BackColor = Color.FromArgb(App_Status.backFormColor.R, App_Status.backFormColor.G, App_Status.backFormColor.B);
        }

        private void BtnPlayOnline1_Click_1(object sender, EventArgs e)
        {
            //CreateNewGameOnline(myUserID, 1);
            //caro_chess.BIsPlaying = true;
            //g.Clear(pnl.BackColor);
            //caro_chess.VeBanCo(g);
            //caro_chess.TaoMangOCo();
            //timer_Load.Enabled = true;
            //caro_chess.StartPlayOnline();
            //btnPlayOnline1.Enabled = false;
            //btnPlayOffline1.Enabled = true;
            //btnChoiMoi1.Enabled = true;
            //pnlGameCaro.Width = 30;
            bunifuTransition1.HideSync(pnlGameCaro);
            //pnl_Friend.Visible = true;
            pnl_Friend.Location = new Point(0, 0);
            bunifuTransition2.ShowSync(pnl_Friend);
            pnl_Friend.Dock = DockStyle.Left;
            GetDataAsync();
            //pnl_Friend.Size = new Size(219, 606);
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            caro_chess.BIsPlaying = false;
            g.Clear(pnl.BackColor);
            caro_chess.VeBanCo(g);
            caro_chess.IGameMode = 0;
            btnPlayOnline1.ButtonText = "Chơi với bạn bè";
            btnPlayOnline1.Enabled = true;
            btnPlayOffline1.Enabled = true;
            btnChoiMoi1.Enabled = false;
        }

        private void BtnThoat1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChoiMoi1_Click_1(object sender, EventArgs e)
        {
            if (caro_chess.IGameMode == 0)
            {
                MessageBox.Show("Chưa chọn chế độ chơi !", "Lỗi");
                return;
            }
            if (caro_chess.IGameMode == 1)
            {
                // play Offline
                caro_chess.BIsPlaying = true;
                g.Clear(pnl.BackColor);
                caro_chess.TaoMangOCo();
                caro_chess.VeBanCo(g);
                caro_chess.StartPlayOffline();
                btnChoiMoi1.Enabled = true;
            }
            else
            {
                // play Online
                CreateNewGameOnline(myUserID, friendUserID);
                caro_chess.BIsPlaying = true;
                g.Clear(pnl.BackColor);
                caro_chess.VeBanCo(g);
                caro_chess.TaoMangOCo();
                timer_Load.Enabled = true;
                caro_chess.StartPlayOnline();
                btnPlayOnline1.ButtonText = "Chơi với " + friendUserName;
                btnPlayOnline1.Enabled = false;
                btnPlayOffline1.Enabled = true;
                btnChoiMoi1.Enabled = true;
            }
        }

        private void Label_NoActiveFriend_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pnl_Friend_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_Friend_MouseEnter(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                Internal_Society.friend atf = item as Internal_Society.friend;
                if (atf != null && atf.BackColor != Color.FromArgb(App_Status.RedTabChat, App_Status.GreenTabChat, App_Status.BlueTabChat)) atf.BackColor = Color.Transparent;
            }
        }
    }
}
