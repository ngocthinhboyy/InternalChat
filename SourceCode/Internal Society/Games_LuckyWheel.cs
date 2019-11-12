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
     
    public partial class Games_LuckyWheel : UserControl
    {
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

        private void Button_play_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            kTarget = 0;
            Random rnd = new Random();
            kTarget = rnd.Next(40, 60);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (kIndex > 8) kIndex = 1;
            if(kTarget < 1) { timer1.Stop(); return; }
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
