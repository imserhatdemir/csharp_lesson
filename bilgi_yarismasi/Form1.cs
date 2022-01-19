using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void Btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldn.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyn.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldn.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyn.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }

        }

        private void Btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldn.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyn.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void Btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;


            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldn.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyn.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void Btns_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btns.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsn.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edilmiştir";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "hangi şehir egede bulunmaz";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Kinyas ve Kayranın yazarı?";
                btna.Text = "Oğuz Atay";
                btnb.Text = "atilla ilhan";
                btnc.Text = "Hakan Günday";
                btnd.Text = "yaşar kemal";
                label4.Text = "Hakan Günday";
                btns.Text = "SONUÇLAR";
            }
            if (soruno == 4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btns.Enabled = false;
                MessageBox.Show("DOĞRU:" + dogru + "\n" + "YANLIŞ:" + yanlis);
            }
        }
    }
}
