﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler {HATALI PLAKA KODU, Adana,Adıyaman,Afyon,Ağrı, Amasya, Ankara, Antalya, Artvin,Aydın,Balıkesir,Bilecik, Bingöl,Bitlis,Bolu,Burdur,Bursa,Çanakkale,Çankırı, Çorum,Denizli,Diyarbakır,Edirne,Elazığ,Erzincan, Erzurum,Eskişehir, Gaziantep,Giresun,Gümüşhane,Hakkari,Hatay, Isparta, Mersin,İstanbul,İzmir, Kars,Kastamonu, Kayseri,Kırklareli, Kırşehir, Kocaeli, Konya, Kütahya, Malatya, Manisa,Kahramanmaraş,Mardin, Muğla,Muş, Nevşehir,Niğde, Ordu, Rize, Sakarya, Samsun, Siirt,Sinop,Sivas,Tekirdağ,Tokat, Trabzon, Tunceli, Şanlıurfa, Uşak, Van, Yozgat, Zonguldak, Aksaray,Bayburt, Karaman, Kırıkkale, Batman, Şırnak, Bartın, Ardahan,Iğdır,Yalova, Karabük, Kilis,Osmaniye, Düzce,
    }
        private void Button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label1.Text = s.ToString();
        }

    }
}
