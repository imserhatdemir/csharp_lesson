using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araçkullanimlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("kasiyer");
            listBox1.Items.Add("Yazılım mühendisi");
            listBox1.Items.Add("Sosyal Hizmet Uzmanı");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2);
        }
    }
}
