using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_siralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // string[] sehirler = { "VAN", "İSTANBUL", "ANKARA", "DİYARBAKIR", "URFA", "ÇANAKKALE", "LONDRA" };
            // for (int i = 0; i < sehirler.Length; i++)
            // {
            //    listBox1.Items.Add(sehirler[i]);
            // }
            ////////////////////////10dan büyük ve çift sayıları listboxa yazan program
            
            int[] sayilar = {25,10,40,60,80 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>=40)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
