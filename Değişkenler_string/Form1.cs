using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // string adsoyad, meslek;
            // adsoyad = "Serhat DEMİR";
            //meslek = "yazılım";
            //  label1.Text = adsoyad;
            //  label2.Text = meslek;
            ////////////////////////////////////////////////////////
            //string sehir;
            // sehir = textBox1.Text;
            //label1.Text = sehir;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string ad, soyad, meslek, dogum;
            ad = textBox1.Text;
            
            soyad = textBox2.Text;
            
            meslek = textBox3.Text;
           
            dogum = maskedTextBox1.Text;
            listBox1.Items.Add(ad + " " + soyad + " " + meslek+ "" +dogum);
            



        }
    }
}
