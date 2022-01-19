using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_ogrencisınavhesaplamaprog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, pro;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            pro = Convert.ToInt32(textBox5.Text);
            ortalama = (s1 + s2 + pro) / 3;
            listBox1.Items.Add(ad + " " + soyad + " ortalama:" + ortalama);
        }
    }
}
