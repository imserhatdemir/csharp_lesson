using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardısık_sayı_toplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // int toplam = 0;
            //  for (int i = 0; i <=10; i++)
            //  {
            //      toplam = toplam + i;

            //    }
            //   label1.Text = toplam.ToString();
            /////////////////////////////////////////////////
            /////////////
            int toplam = 0;
            for (int i = 2; i <=20; i+=2)
            {
                toplam = toplam + i;
            }
            label2.Text = toplam.ToString();
        }
    }
}
