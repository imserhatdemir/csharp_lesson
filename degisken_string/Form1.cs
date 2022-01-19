using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, meslek, dogum;
            ad = textBox1.Text;

            soyad = textBox2.Text;

            meslek = textBox3.Text;

            dogum = maskedTextBox1.Text;
            listBox1.Items.Add(ad + " " + soyad + " " + meslek + "" + dogum);
        }
    }
}
