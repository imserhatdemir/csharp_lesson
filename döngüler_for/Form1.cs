﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace döngüler_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // int i;
            //  for (i = 1; i <= 10; i++)
            // {
            ///      listBox1.Items.Add(i+"MERHABA");
            // }
            //////////////Ekrana birden ona kadar sayıları yazdıran program
            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
