using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text)
            {
                MessageBox.Show ("BAŞARILI");
            }
            else { MessageBox.Show("HATA"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            string[] sembol3 = { "A", "B", "C", "D", "E", "F", "G" };
            Random r = new Random();
            int s1, s2, s3, s4;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 10);
            s4 = r.Next(0, sembol3.Length);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s4].ToString() + s3.ToString();
            label1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
