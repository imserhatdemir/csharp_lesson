using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /// double sayi;
            //sayi = 4.25;
            // label1.Text = sayi.ToString();
            ////////////////////////////////eğer kodlamada double değişkeninde sayı girerseniz "," klavyeden sayı girerseniz "." kullanmalısınız.
            //double s1, s2, s3, ort;
            // s1 = 60;
            // s2 = 70;
            // s3 = 57;
            //ort = (s1 + s2 + s3) / 3;
            // label1.Text = ort.ToString("0.00");
            ////////////////////////////////////////////
            double sayi=Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();

        }
    }
}
