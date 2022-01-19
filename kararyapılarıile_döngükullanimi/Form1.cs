using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kararyapılarıile_döngükullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i <=100; i++)
            // {
            //    if (i % 5 == 0 && i % 7==0)
            //   {
            //       listBox1.Items.Add(i);
            //  }
            // }
            ///////////////////////////////////
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi%i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
