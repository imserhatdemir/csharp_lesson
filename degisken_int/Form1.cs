using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // int sayi;
            //  sayi = 24;
            // label1.Text = sayi.ToString();
            /////////////////////////////////
            //int sayi1, sayi2, toplam;
            // sayi1 = 5;
            // sayi2 = 4;
            // toplam = sayi1 + sayi2;
            // label1.Text = toplam.ToString();
            /////////////////////////////////////////////
            // int kenar, alan, cevre;
            // kenar = 10;
            // alan = kenar * kenar;
            // cevre = kenar * 4;
            //label1.Text = "alan:" + alan + " çevre:"+cevre;
            ///////////////////////////////////////////////////
            /////3 sınav notu girilen  öğrencinin ortalamasını hesaplayan kod
            int sınav1, sınav2, sınav3, ortalama;
            sınav1 = 70;
            sınav2 = 90;
            sınav3 = 65;
            ortalama = (sınav1 + sınav2 + sınav3) / 3;
            label1.Text="1.Sınav notu: "+sınav1+" 2.Sınav notu:"+sınav2+" 3.Sınav notu:"+sınav3+" Ortalama:"+ortalama;
        }
    }
}
