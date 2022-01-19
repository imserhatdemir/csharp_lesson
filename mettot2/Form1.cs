using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mettot2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  int toplam(int s1, int s2, int s4)
        // {
        //   int s3 = s1 * s2*s4;
        // return s3;
        //}
        int küp(int s1,int s2)
        {
            int sonuc = s1+s2;
            return sonuc;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            0000
            //  label1.Text = toplam(4, 6,8).ToString();
            int ss1 = Convert.ToInt32(textBox1.Text);
            int ss2 = Convert.ToInt32(textBox2.Text);
            label1.Text = küp(ss1,ss2).ToString();
            if(ss1+ss2<=32)
            {
                label2.Text = "BAŞARILI";
                for(int i = 0; i < 32; i++)
                {
                    listBox1.Items.Add(i++);
                }
            }
        }

    }
}
