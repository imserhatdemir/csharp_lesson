using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //kullanıcının girdiği sayıya göre ay verme programı//int ile
            //int ay = Convert.ToInt32(textBox1.Text);
            ///  switch (ay)
            // {
            //  case 1:label2.Text = "Ocak";break;
            //  case 2: label2.Text = "Şubat"; break;
            // case 3: label2.Text = "Mart"; break;
            /// case 4: label2.Text = "Nisan"; break;
            // case 5: label2.Text = "Mayıs"; break;
            ///  case 6: label2.Text = "Haziran"; break;
            //  case 7: label2.Text = "Temmuz"; break;
            //  case 8: label2.Text = "Ağustos"; break;
            // case 9: label2.Text = "Eylül"; break;
            // case 10: label2.Text = "Ekim"; break;
            //case 11: label2.Text = "Kasım"; break;
            //  case 12: label2.Text = "Aralık"; break;
            // default:label2.Text = "HATALI AY!";break;
            // }
            //////////////////////////
            /////klavyeden girilen mevsime göre ay veren program//string ile
            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "yaz":label2.Text = "HAZİRAN,TEMMUZ,AĞUSTOS";break;
                case "ilkbahar": label2.Text = "MART,NİSAN,MAYIS"; break;
                case "sonbahar": label2.Text = "EYLÜL,EKİM,KASIM"; break;
                case "kış": label2.Text = "ARALIK,OCAK,ŞUBAT"; break;
                default:label2.Text = "HATALI MEVSİM GİRİŞİ YAPTINIIZ!";break;
            }
        }
    }
}
