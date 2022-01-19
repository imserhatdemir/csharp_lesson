using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamik_araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20,10);
            btn.Location = btnkonum;
            btn.Name = "button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Blue;
            btn.Width = 73;
            btn.Height = 50;

            Label lbl = new Label();
            Point lblkonum = new Point(100, 25);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Naber";
            lbl.BackColor = Color.Pink;
            lbl.AutoSize = true;
            
            this.Controls.Add(lbl);
            this.Controls.Add(btn);


            for (int i = 0; i <=5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i * 30);
                txt.Location = txtkonum;
                txt.Name = "Textbox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
           
        }
    }
}
