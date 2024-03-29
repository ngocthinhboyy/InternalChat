﻿using System.Drawing;

namespace Internal_Society
{
    class O_Co
    {
        // Ban Co 400 O_Co => 25 * 20 = 500 (kich thuoc panel em chon);
        public const int iChieuDai_O = 25;
        public const int iChieuCao_O = 25;
        private int iDong;

        public int IDong
        {
            get { return iDong; }
            set { iDong = value; }
        }
        private int iCot;

        public int ICot
        {
            get { return iCot; }
            set { iCot = value; }
        }
        private int iSo_Huu;
        public int ISo_Huu
        {
            get { return iSo_Huu; }
            set { iSo_Huu = value; }
        }

        private Point iStart_Position = new Point();
        public Point IStart_Position
        {
            get { return iStart_Position; }
            set { iStart_Position = value; }
        }
        private Point iEnd_Position = new Point();
        public Point IEnd_Position
        {
            get { return iEnd_Position; }
            set { iEnd_Position = value; }
        }
        public O_Co(Point Start, Point End)
        {
            iStart_Position = Start;
            iEnd_Position = End;
        }
        public O_Co()
        { }
        public O_Co(int Dong, int Cot)
        {
            iDong = Dong;
            iCot = Cot;
        }
        // So Huu cho biet player 1 hay player 2 la nguoi danh o co nay
        public O_Co(int Dong, int Cot, int SoHuu)
        {
            iDong = Dong;
            iCot = Cot;
            iSo_Huu = SoHuu;
        }

        public void Ve_O_Co(Graphics g, Color c)
        {
            g.DrawRectangle(new Pen(c), this.iStart_Position.X, this.iStart_Position.Y, iChieuDai_O, iChieuCao_O);
        }
    }
}
