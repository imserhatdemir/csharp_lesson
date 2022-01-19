using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemasatışuygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt32(txtmsr.Text);
            bilet = Convert.ToInt32(txtblt.Text);
            su = Convert.ToInt32(txtsu.Text);
            cay = Convert.ToInt32(txtcy.Text);
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            labeltplm.Text = toplam.ToString();
            kasatutar = kasatutar + toplam;
            labelks.Text = kasatutar.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtblt.Text = "";
            txtcy.Text = "";
            txtmsr.Text = "";
            txtsu.Text = "";
            txtmsr.Focus();
        }
    }
}
