﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mat_fonksiyonlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(sayi).ToString();
            //label2.Text = Math.Ceiling(sayi).ToString();
            //label2.Text = Math.Floor(sayi).ToString();
            //  label2.Text = Math.Pow(sayi,3).ToString();
            label2.Text = Math.Sqrt(sayi).ToString();
        }
    }
} 
/*
*abs= mutlak 
*ceil=üste yuvarlama
* *floor=alta yuvarlama
* *pow=üs alma
* *sqrt=karekök alma
*/
