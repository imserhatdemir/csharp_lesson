using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int toplam = 0,adet=0,ort=0;
            int[] sınavlar = { 40, 20, 15, 12, 31, 13, 23, 32 };
            foreach (int x in sınavlar)
            {
                if (x % 4 == 0)
                {
                    listBox1.Items.Add(x);
                    toplam = toplam + x;
                     adet++;
                    ort = toplam / adet;
                }
            }
            label1.Text = toplam.ToString();
            label2.Text = ort.ToString();
            label3.Text = adet.ToString();
            
        }
    }
}
