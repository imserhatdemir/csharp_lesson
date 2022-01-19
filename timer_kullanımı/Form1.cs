using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 15)
            {
               
                this.BackColor = Color.Blue;
            }
            if (sayac == 30)
            {
                this.BackColor = Color.Red;
                sayac = 0;
            }
          
        }
    }
}
