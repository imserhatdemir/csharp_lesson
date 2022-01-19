using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_yapilari_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int kadet;
            double toplam;
            kadet = Convert.ToInt32(textBox1.Text);
            if (kadet >= 0 && kadet <= 20)
            {
                toplam = (kadet * 8)-(kadet*8*0.20);
                label3.Text = toplam + "TL";
            }
            if (kadet >= 21 && kadet <= 40)
            {
                toplam = (kadet * 8) - (kadet * 8 * 0.40);
                label3.Text = toplam + "TL";
            }
            if (kadet >= 41)
            {
                toplam = (kadet * 8) - (kadet * 8 * 0.50);
                label3.Text = toplam + "TL";
            }
        }
    }
}
