using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler= { "serhat", "ezgi", "vedat", "serdar", "yahya" };
            //foreach  (string k in kisiler)
            //{
            //  listBox1.Items.Add(k);
            //}
            //////////////////////////////
            int toplam = 0;
            int[] sinavlar = { 15, 75, 65, 34, 90, 85 };
            foreach (int x in sinavlar)

            {
                
                listBox1.Items.Add(x);
                toplam = toplam + x;
            }
            label1.Text = toplam.ToString();
            int ortalama = toplam / sinavlar.Length;
            label2.Text = ortalama.ToString();
        }
    }
}
