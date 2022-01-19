using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // string[] kisiler={ "Ali","Ahmet","Mehmet","Serhat","Ezgi","Vedat"};
            //label1.Text = kisiler[4];
            //////////////////////////////////////
            int[] sayi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 54, 4, 3, 2, 1 };
            label1.Text = sayi[10].ToString();
        }
    }
}
