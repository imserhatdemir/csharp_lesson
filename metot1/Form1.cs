using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metot1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Text = "SERHAT";
            textBox2.Text = "DEMİR";
            textBox3.Text = "İSTANBUL";
            textBox4.Text = "VAN    ";
            textBox1.Focus();
        }
        void renklendir()
        {
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Black;
            textBox3.BackColor = Color.DarkBlue;
            textBox4.BackColor = Color.Pink;
            textBox1.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
