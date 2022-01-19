using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //   if (textBox1.Text == "serhat") 
            // {
            ///     label1.Text = "Hoşgeldin serhat";
            // }
            // else
            //  {
            //      label1.Text = "hatalı giriş";
            //  }
            //////////////////////////////
            /// int sayi = Convert.ToInt32(textBox1.Text);
            ///if (sayi==5)
            //{
            //  label1.Text = "doğru";
            //}
            //else
            //{
            //  label1.Text = "yanlış";
            //}
            /////////////////////klavyeden girilen sayının tek mi çift mi olduğunu bulan program
            // int sayi = Convert.ToInt32(textBox1.Text);
            //   if (sayi % 2 == 0)
            //  {
            //      label1.Text = "Sayı Çifttir";
            //  }
            //   else
            //   {
            //      label1.Text = "sayı tektir";
            //}
            /////////////////////////////klavyeden girilen sayının 10'dan büyük ve çift olması
            // int sayi = Convert.ToInt32(textBox1.Text);
            //  if (sayi >= 10 && sayi % 2 == 0) 
            // {
            //      label1.Text = "doğru";
            // }else
            //  {
            //     label1.Text = "yanlış";
            // }
            //////////////////////////////10'dan büyük veya çift
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi >= 10 || sayi % 2 == 0) 
            {
                 label1.Text = "doğru";
             }else
             {
                label1.Text = "yanlış";
            }
        }
    }
}
