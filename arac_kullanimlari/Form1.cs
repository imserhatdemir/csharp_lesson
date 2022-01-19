using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = "serhat";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Serhat";
            label7.Text = "Demir";
            label8.Text="Yazılımcı";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazılım Mühendisi";
            label9.Text = textBox1.Text;
        }
    }
}
