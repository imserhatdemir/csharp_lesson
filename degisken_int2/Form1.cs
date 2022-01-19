using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_int2
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
            //sayi = Convert.ToInt32(textBox1.Text);
            //  label2.Text = sayi.ToString();
            /////////////////////////////////
            /////Girilen sayının küpünü bulan program;
            int sayi,sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            label2.Text = sonuc.ToString();

        }
    }
}
