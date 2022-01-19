using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MaviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepSkyBlue;
        }

        private void GriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void TuruncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void HakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje serhat demir tarafından hazırlanmıştır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MadMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            label1.Text = "Mad Max";
        }

        private void PcILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
            label1.Text = "PS I LOVE YOU";
        }

        private void AynuYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aQnlngjZG48");
            label1.Text = "Aynı Yıldızın Altında";
        }

        private void KorkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E");
            label1.Text = "Korku Seansı";
        }

        private void AvengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=J9kaR31Bq5k");
            label1.Text = "Avengers End Game";
        }
    }
}
