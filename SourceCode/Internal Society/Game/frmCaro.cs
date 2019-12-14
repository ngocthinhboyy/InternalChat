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

namespace Internal_Society
{
    public partial class frmCaro : Form
    {
        Graphics g;
        Caro_Chess caro_chess = new Caro_Chess();
        int myUserID = Convert.ToInt32(User_Info.k_ID);
        private bool mouseDown;
        private Point lastLocation;
        int myGameID = -1;
        bool isMyUserTurnInOnline = true;
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
                caro_chess.EndgameOnline();
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
            btnPlayOffline1.Enabled = false;
            btnPlayOnline1.Enabled = true;
            btnChoiMoi1.Enabled = true;
        }

        private void BtnPlayOnline1_Click_1(object sender, EventArgs e)
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

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            caro_chess.BIsPlaying = false;
            g.Clear(pnl.BackColor);
            caro_chess.VeBanCo(g);
            caro_chess.IGameMode = 0;
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
                CreateNewGameOnline(myUserID, 1);
                caro_chess.BIsPlaying = true;
                g.Clear(pnl.BackColor);
                caro_chess.TaoMangOCo();
                caro_chess.VeBanCo(g);
                caro_chess.StartPlayOnline();
                btnChoiMoi1.Enabled = true;
            }
        }
    }
}
