using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Internal_Society
{
    class Caro_Chess
    {
        private O_Co[,] Mang_O_Co = new O_Co[20, 20];
        // danh sach cac nuoc da di
        public List<O_Co> lCacNuocDaDi = new List<O_Co>();
        private Ban_Co BanCo = new Ban_Co();
        // lay tam hinh cua O
        private Image ImageO = new Bitmap(Properties.Resources._76702389_482550149040133_3998274060453675008_n);
        // lay tam hinh cua X
        private Image ImageX = new Bitmap(Properties.Resources._80017681_721804111677896_4503219617254080512_n);
        // luot di 1 là nguoi choi dau tien 2 la nguoi choi sau do
        public int iLuotDi = 1;
        private bool bIsPlaying = false;
        // iGameMode = 1 choi offline   
        // iGameMode = 2= choi online
        private int iGameMode = 0;
        private string previousData = "";
        public O_Co[,] MMang_O_Co
        {
            get { return Mang_O_Co; }
            set { Mang_O_Co = value; }
        }
        public int ILuotDi
        {
            get { return iLuotDi; }
            set { iLuotDi = value; }
        }
        public List<O_Co> LCacNuocDaDi
        {
            get { return lCacNuocDaDi; }
            set { lCacNuocDaDi = value; }
        }

        public string PreviousData
        {
            get { return previousData; }
            set { previousData = value; }
        }

        public bool BIsPlaying
        {
            get { return bIsPlaying; }
            set { bIsPlaying = value; }
        }
        public int IGameMode
        {
            get { return iGameMode; }
            set { iGameMode = value; }
        }

        #region CacPhuongThucVeVaKhoiTao
        public void TaoMangOCo()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Mang_O_Co[i, j].IDong = i;
                    Mang_O_Co[i, j].ICot = j;
                    Mang_O_Co[i, j].ISo_Huu = 0;
                }
            }
        }
        public void VeBanCo(Graphics g)
        {
            BanCo.VeBanCo(g, Mang_O_Co);
        }
        public void KiemTraVeLai(Graphics g)
        {
            if (lCacNuocDaDi.Count == 0)
            {
                BanCo.VeBanCo(g, Mang_O_Co);
            }
            else
            {
                BanCo.VeLaiBanCo(g, Mang_O_Co, ImageX, ImageO);
            }
        }
        public void XacDinhVeOCo(int MouseX, int MouseY, Graphics g)
        {
            for (int i = 0; i < BanCo.ISoDong; i++)
            {
                if (BanCo.DinhViDong(MouseY, i, Mang_O_Co))
                {
                    for (int j = 0; j < BanCo.ISoCot; j++)
                    {
                        if (BanCo.DinhViCot(MouseX, j, Mang_O_Co))
                        {
                            switch (iLuotDi)
                            {
                                case 1:
                                    {
                                        if (Mang_O_Co[i, j].ISo_Huu != 0)
                                            return;
                                        BanCo.VeQuanCo(g, i, j, ImageX, Mang_O_Co);
                                        Mang_O_Co[i, j].ISo_Huu = 1;
                                        Mang_O_Co[i, j].IDong = i;
                                        Mang_O_Co[i, j].ICot = j;
                                        lCacNuocDaDi.Add(Mang_O_Co[i, j]);
                                        iLuotDi = 2;
                                        return;
                                    }
                                case 2:
                                    {
                                        if (Mang_O_Co[i, j].ISo_Huu != 0)
                                            return;
                                        BanCo.VeQuanCo(g, i, j, ImageO, Mang_O_Co);
                                        Mang_O_Co[i, j].ISo_Huu = 2;
                                        Mang_O_Co[i, j].IDong = i;
                                        Mang_O_Co[i, j].ICot = j;
                                        lCacNuocDaDi.Add(Mang_O_Co[i, j]);
                                        iLuotDi = 1;
                                        return;
                                    }
                            }
                        }
                    }
                }
            }
        }
        public void StartPlayOffline()
        {
            iGameMode = 1;
            iLuotDi = 1;
            lCacNuocDaDi.RemoveRange(0, lCacNuocDaDi.Count);
        }
        public void StartPlayOnline()
        {
            iGameMode = 2;
            iLuotDi = 1;
            lCacNuocDaDi.RemoveRange(0, lCacNuocDaDi.Count);
        }
        #endregion
        #region KiemTraChienThang

        public void EndgameOnline(string username2, int iTurn,int myID, int friendID)
        {
            /*
            switch (iTurn)
            {
                case 1:
                    string sName1 = username2 + " đã chiến thắng!!";
                    IncorrectAlert incorrect1 = new IncorrectAlert(sName1);
                    incorrect1.Show();
                    break;
                case 2:
                    
                    string sName2 = User_Info.k_Fullname.ToString() + " đã chiến thắng!!";
                    IncorrectAlert incorrect2 = new IncorrectAlert(sName2);
                    incorrect2.Show();
                    break;
            }
            */
            if(iTurn == myID)
            {

                string sName1 = "Bạn đã thua!!";
                IncorrectAlert incorrect1 = new IncorrectAlert(sName1);
                incorrect1.Show();
            }
            else if(iTurn == friendID)
            {
                string sName2 = "Bạn đã chiến thắng!!";
                IncorrectAlert incorrect2 = new IncorrectAlert(sName2);
                incorrect2.Show();
            }
        }
        public void EndgameOffline()
        {
            switch (iLuotDi)
            {
                case 1:
                    IncorrectAlert incorrect2 = new IncorrectAlert("Player 2 đã chiến thắng");
                    incorrect2.Show();
                    break;
                case 2:
                    IncorrectAlert incorrect1 = new IncorrectAlert("Player 1 đã chiến thắng");
                    incorrect1.Show();
                    break;
            }
        }
        public bool KiemTraChienThang()
        {
            if (lCacNuocDaDi.Count == 400)
            {
                MessageBox.Show("Hòa Cờ!!!!");
                bIsPlaying = false;
                return false;
            }
            else
            {
                for (int i = 0; i < BanCo.ISoDong; i++)
                {
                    for (int j = 0; j < BanCo.ISoCot; j++)
                    {
                        if (Mang_O_Co[i, j].ISo_Huu == 1)
                        {
                            if (KiemTraPlayerWin(i, j, 1))
                                return true;
                        }
                        if (Mang_O_Co[i, j].ISo_Huu == 2)
                        {
                            if (KiemTraPlayerWin(i, j, 2))
                                return true;
                        }
                    }
                }
                return false;
            }
        }
        // duyet phuong doc theo 1 o co
        private bool DuyetPhuongDoc(int currentDong, int currentCot, int playerSoHuu)
        {
            int iDemSoCo;
            if (currentDong > 15)
            {
                return false;
            }
            else
            {
                for (iDemSoCo = 1; iDemSoCo < 5; iDemSoCo++)
                {
                    if (Mang_O_Co[currentDong + iDemSoCo, currentCot].ISo_Huu != playerSoHuu)
                        return false;
                }
                if (currentDong == 0 || currentDong + iDemSoCo == BanCo.ISoDong)
                    return true;
                else
                {
                    if (Mang_O_Co[currentDong - 1, currentCot].ISo_Huu == 0 || Mang_O_Co[currentDong + iDemSoCo, currentCot].ISo_Huu == 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        // duyet phuong ngang theo 1 o co
        private bool DuyetPhuongNgang(int currentDong, int currentCot, int playerSoHuu)
        {
            int iDemSoCo;
            if (currentCot > 15)
                return false;
            for (iDemSoCo = 1; iDemSoCo < 5; iDemSoCo++)
            {
                if (Mang_O_Co[currentDong, currentCot + iDemSoCo].ISo_Huu != playerSoHuu)
                    return false;
            }
            if (currentCot == 0 || currentCot + iDemSoCo == BanCo.ISoCot)
                return true;
            else
            {
                if (Mang_O_Co[currentDong, currentCot - 1].ISo_Huu == 0 || Mang_O_Co[currentDong, currentCot + iDemSoCo].ISo_Huu == 0)
                    return true;
                else
                    return false;
            }
        }

        // duyet phuong cheo xuoi theo 1 o co
        private bool DuyetCheoXuoi(int currentDong, int currentCot, int playerSoHuu)
        {
            int iDemSoCo;
            if (currentDong > 15 || currentCot > 15)
                return false;
            for (iDemSoCo = 1; iDemSoCo < 5; iDemSoCo++)
            {
                if (Mang_O_Co[currentDong + iDemSoCo, currentCot + iDemSoCo].ISo_Huu != playerSoHuu)
                    return false;
            }
            if (currentCot == 0 || currentDong == 0 || currentCot + iDemSoCo == BanCo.ISoCot || currentDong + iDemSoCo == BanCo.ISoDong)
                return true;
            else
            {
                if (Mang_O_Co[currentDong - 1, currentCot - 1].ISo_Huu == 0 || Mang_O_Co[currentDong + iDemSoCo, currentCot + iDemSoCo].ISo_Huu == 0)
                    return true;
                else
                    return false;
            }
        }

        // duyet phuong cheo nguoc theo 1 o co
        private bool DuyetCheoNguoc(int currentDong, int currentCot, int playerSoHuu)
        {
            int iDemSoCo;
            if (currentDong > 15 || currentCot < 4)
                return false;
            for (iDemSoCo = 1; iDemSoCo < 5; iDemSoCo++)
            {
                if (Mang_O_Co[currentDong + iDemSoCo, currentCot - iDemSoCo].ISo_Huu != playerSoHuu)
                    return false;
            }
            if (currentCot == BanCo.ISoCot - 1 || currentDong == 0 || currentCot - iDemSoCo == BanCo.ISoCot || currentDong + iDemSoCo == BanCo.ISoDong)
                return true;
            else
            {
                if (Mang_O_Co[currentDong - 1, currentCot + 1].ISo_Huu == 0 || Mang_O_Co[currentDong + iDemSoCo, currentCot - iDemSoCo].ISo_Huu == 0)
                    return true;
                else
                    return false;
            }
        }
        private bool KiemTraPlayerWin(int Dong, int Cot, int Player_SoHuu)
        {
            if (DuyetPhuongDoc(Dong, Cot, Player_SoHuu) || DuyetPhuongNgang(Dong, Cot, Player_SoHuu) || DuyetCheoXuoi(Dong, Cot, Player_SoHuu) || DuyetCheoNguoc(Dong, Cot, Player_SoHuu))
                return true;
            return false;
        }

        #endregion

        #region PlayOnline
        public async void GetDataFromDBWithGameID(Graphics g, int id)
        {
            string urlRequest = App_Status.urlAPI + "c_Caro/Get_Data/" + id;
            //string urlRequest = "https://kunbr0.com/kunbr0/get_data.php?game_id=" + id;
            Task<string> getStringTask = Task.Run(() => { return new WebClient().DownloadString(urlRequest); });
            string result = await getStringTask;
            dynamic data = JsonConvert.DeserializeObject(result);
            string newestData = data.data.ToString();
            VeLaiBanCoSauKhiLayData(g, newestData);
        }
        public void VeLaiBanCoSauKhiLayData(Graphics g, string rawStringFromDB)
        {
            string[] splitrawString = { "a", "b", "," };
            string[] listNumber = rawStringFromDB.Split(splitrawString, StringSplitOptions.RemoveEmptyEntries);
            int[] arrInt = new int[1200];
            int i = 0;
            int iCot = 0;
            int iDong = 0;
            int iPlayerLast = 0;
            foreach (string s in listNumber)
            {
                arrInt[i] = Convert.ToInt32(s);
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                iCot = arrInt[j];
                iDong = arrInt[j + 1];
                Mang_O_Co[iDong, iCot].ISo_Huu = arrInt[j + 2] + 1;
                lCacNuocDaDi.Add(Mang_O_Co[iDong, iCot]);
                iPlayerLast = arrInt[j + 2] + 1;
                j = j + 2;
            }
            if (iPlayerLast == 1)
                iLuotDi = 2;
            else
                iLuotDi = 1;
            KiemTraVeLai(g);

        }
        public void XacDinhVeOCoSauKhiCoThayDoiTuDB(int i, int j, Graphics g)
        {
            if (Mang_O_Co[i, j].ISo_Huu == 1)
            {
                BanCo.VeQuanCo(g, i, j, ImageX, Mang_O_Co);
                Mang_O_Co[i, j].ISo_Huu = 1;
                Mang_O_Co[i, j].IDong = i;
                Mang_O_Co[i, j].ICot = j;
                iLuotDi = 2;
            }
            else
            {
                BanCo.VeQuanCo(g, i, j, ImageO, Mang_O_Co);
                Mang_O_Co[i, j].ISo_Huu = 2;
                Mang_O_Co[i, j].IDong = i;
                Mang_O_Co[i, j].ICot = j;
                iLuotDi = 1;
            }
        }
        #endregion

    }
}
