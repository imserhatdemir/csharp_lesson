using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba rb = new araba();
            rb.renk = "MAVİ";
            rb.hız = 160;
            rb.motor = 1245.56;
            rb.fiyat = 5000;
            rb.durum = 's';
            rb.YIL = -2020;
            rb.MARKASI = "TOYOTA";
            rb.muayene = 2017;
            rb.plaka = "34 VI 65";
            rb.sahip = "Serhat DEMİR";

            label1.Text = rb.renk;
            label2.Text = rb.hız.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.sahip;
            pictureBox1.BackColor = Color.DarkBlue;
        }
    }
}
