﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace char_degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // char takim;
            // takim = 'f';
            // label1.Text = takim.ToString();
            //////////////////////////////////////
            char ders;
            ders = Convert.ToChar(textBox1.Text);
            label1.Text = ders.ToString();
        }
    }
}
