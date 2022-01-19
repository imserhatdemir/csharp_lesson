using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
            string islem,sonuc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            islem = textBox3.Text;
           
            switch (islem)
            {
                case "+":sonuc = textBox4.Text= Convert.ToString(s1+s2) ;break;
                case "-": sonuc = textBox4.Text = Convert.ToString(s1 - s2); break;
                case "*": sonuc = textBox4.Text = Convert.ToString(s1 * s2); break;
                case "/": sonuc = textBox4.Text = Convert.ToString(s1 / s2); break;
                default:MessageBox.Show( "hatalı sembol");break;
            }
        }
    }
}
