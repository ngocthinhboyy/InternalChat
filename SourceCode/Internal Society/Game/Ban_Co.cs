using System.Drawing;

namespace Internal_Society
{
    class Ban_Co
    {
        private int iSoDong = 20;

        public int ISoDong
        {
            get { return iSoDong; }
            set { iSoDong = value; }
        }

        private int iSoCot = 20;
        public int ISoCot
        {
            get { return iSoCot; }
            set { iSoCot = value; }
        }

        public void VeBanCo(Graphics g, O_Co[,] Mang_O_Co)
        {
            for (int i = 0; i < iSoDong; i++)
            {
                for (int j = 0; j < ISoCot; j++)
                {
                    // diem bat dau cua o co
                    Point pointStart = new Point(j * O_Co.iChieuDai_O, i * O_Co.iChieuCao_O);
                    // diem ket thuc cua o co
                    Point pointEnd = new Point(j * O_Co.iChieuDai_O + O_Co.iChieuDai_O, i * O_Co.iChieuCao_O + O_Co.iChieuCao_O);
                    Mang_O_Co[i, j] = new O_Co(pointStart, pointEnd);
                    Mang_O_Co[i, j].Ve_O_Co(g, Color.White);
                }
            }
        }

        public void VeQuanCo(Graphics g, Point pointStart, Image img)
        {
            g.DrawImage(img, pointStart.X + 1, pointStart.Y + 1, O_Co.iChieuDai_O - 1, O_Co.iChieuCao_O - 1);
        }

        // ve lai ban co duoc goi khi nguoi dung out khoi chuong trinh roi vo lai.
        public void VeLaiBanCo(Graphics g, O_Co[,] Mang_O_Co, Image imgX, Image imgO)
        {
            for (int i = 0; i < iSoDong; i++)
            {
                for (int j = 0; j < iSoCot; j++)
                {
                    Mang_O_Co[i, j].Ve_O_Co(g, Color.White);
                    if (Mang_O_Co[i, j].ISo_Huu == 1)
                    {
                        VeQuanCo(g, Mang_O_Co[i, j].IStart_Position, imgX);
                    }
                    if (Mang_O_Co[i, j].ISo_Huu == 2)
                    {
                        VeQuanCo(g, Mang_O_Co[i, j].IStart_Position, imgO);
                    }
                }
            }
        }

        public bool DinhViDong(int MouseY, int Dong, O_Co[,] Mang_O_Co)
        {
            if (Mang_O_Co[Dong, 0].IStart_Position.Y < MouseY && Mang_O_Co[Dong, 0].IEnd_Position.Y > MouseY)
            {
                return true;
            }
            return false;
        }
        public bool DinhViCot(int MouseX, int Cot, O_Co[,] Mang_O_Co)
        {
            if (Mang_O_Co[0, Cot].IStart_Position.X < MouseX && Mang_O_Co[0, Cot].IEnd_Position.X > MouseX)
            {
                return true;
            }
            return false;
        }
        public void VeQuanCo(Graphics g, int Dong, int Cot, Image img, O_Co[,] Mang_O_Co)
        {
            g.DrawImage(img, Mang_O_Co[Dong, Cot].IStart_Position.X + 1, Mang_O_Co[Dong, Cot].IStart_Position.Y + 1, O_Co.iChieuDai_O - 1, O_Co.iChieuCao_O - 1);
        }
    }
}
