﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: "+ maskedTextBox1.Text + " Yolcu Bilgileri ~~ Ad/Soyad:"+ textBox1.Text + " T.C. No: " + maskedTextBox2.Text +" Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
