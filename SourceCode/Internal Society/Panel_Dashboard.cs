using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.DataViz.WinForms;

namespace Internal_Society
{
    public partial class Panel_Dashboard : UserControl
    {

        public Panel_Dashboard()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        // Truyen vao bunifudataviz + so duong ke, so diem tren duong ke, ten cua moi diem, so lieu cua moi diem
        private void CreateSplineChart(BunifuDataViz buDataViz, int numberLine, int numberPoint,int[] arrNameEachPoint, int[] arrData)
        {
            buDataViz.colorSet.Clear();
            DataPoint[] datapointArr = new DataPoint[100];
            for (int i = 0; i < numberLine; i++)
            {
                datapointArr[i] = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            }
            for(int i = 0; i < numberPoint; i++)
            {
                for(int j = 0; j < numberLine; j++)
                {
                    datapointArr[j].addLabely(arrNameEachPoint[i].ToString(), arrData[i]);
                }
            }
            Canvas canvas = new Canvas();
            for(int i = 0; i < numberLine; i++)
            {
                canvas.addData(datapointArr[i]);
            }
            buDataViz.Render(canvas);
        }
        // Column Chart
        private void CreateColumnChart(BunifuDataViz buDataViz, int numberLine, int numberPoint, int[] arrNameEachPoint, int[] arrData)
        {
            buDataViz.colorSet.Clear();
            DataPoint[] datapointArr = new DataPoint[100];
            for (int i = 0; i < numberLine; i++)
            {
                datapointArr[i] = new DataPoint(BunifuDataViz._type.Bunifu_column);
            }
            for (int i = 0; i <= numberPoint; i++)
            {
                for (int j = 0; j < numberLine; j++)
                {
                    datapointArr[j].addLabely(arrNameEachPoint[i].ToString(), arrData[i]);
                }
            }
            Canvas canvas = new Canvas();
            for (int i = 0; i < numberLine; i++)
            {
                canvas.addData(datapointArr[i]);
            }
            buDataViz.Render(canvas);
        }
        // Pie Chart
        private void CreatePieChart(BunifuDataViz buDataViz, int numberPie, int[] arrNameEachPoint, int[] arrData)
        {
            buDataViz.colorSet.Clear();
            DataPoint datapoint = new DataPoint(BunifuDataViz._type.Bunifu_pie);
            for(int i = 0; i < numberPie; i++)
            {
                datapoint.addLabely(arrNameEachPoint[i].ToString(), arrData[i].ToString());
            }
            Canvas canvas = new Canvas();
            canvas.addData(datapoint);
            buDataViz.Render(canvas);
        }
        private void RendersCharts_Tick(object sender, EventArgs e)
        {
            RendersCharts.Stop();

            bunifuDataViz1.colorSet.Clear();
            bunifuDataViz2.colorSet.Clear();
            bunifuDataViz3.colorSet.Clear();



            DataPoint c1 = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            DataPoint c2 = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            DataPoint c3 = new DataPoint(BunifuDataViz._type.Bunifu_spline);


            DataPoint b1 = new DataPoint(BunifuDataViz._type.Bunifu_column);
            DataPoint b2 = new DataPoint(BunifuDataViz._type.Bunifu_column);
            DataPoint b3 = new DataPoint(BunifuDataViz._type.Bunifu_column);

            DataPoint d1 = new DataPoint(BunifuDataViz._type.Bunifu_pie);
            

            



            Random ran = new Random();
            for(int i = 0; i <= 10; i++)
            {
                c1.addLabely(i.ToString(), ran.Next(1, 50));
                c2.addLabely(i.ToString(), ran.Next(1, 50));
                c3.addLabely(i.ToString(), ran.Next(1, 50));

                b1.addLabely(i.ToString(), ran.Next(1, 50));
                b2.addLabely(i.ToString(), ran.Next(1, 50));
                b3.addLabely(i.ToString(), ran.Next(1, 50));
                



            }
            d1.addLabely("MON", ran.Next(0, 50).ToString());
            d1.addLabely("TUE", ran.Next(0, 50).ToString());
            d1.addLabely("WED", ran.Next(0, 50).ToString());
            d1.addLabely("THU", ran.Next(0, 50).ToString());
            d1.addLabely("FRI", ran.Next(0, 50).ToString());
            d1.addLabely("SAT", ran.Next(0, 50).ToString());
            d1.addLabely("SUN", ran.Next(0, 50).ToString());


            Canvas canvas = new Canvas();
            canvas.addData(c1);
            canvas.addData(c2);
            canvas.addData(c3);


            bunifuDataViz1.Render(canvas);

            Canvas canvas1 = new Canvas();
            canvas1.addData(b1);
            canvas1.addData(b2);
            canvas1.addData(b3);


            bunifuDataViz2.Render(canvas1);
            Canvas canvas2 = new Canvas();
            canvas2.addData(d1);
            

            bunifuDataViz3.Render(canvas2);
        }

        private void BunifuDataViz1_Load(object sender, EventArgs e)
        {

        }
    }
}
