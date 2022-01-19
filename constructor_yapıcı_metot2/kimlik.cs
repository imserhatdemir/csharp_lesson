using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_yapıcı_metot2
{
    class kimlik
    {
        string ad;
        string soyad;
        string memleket;
        int yaş;
        char cinsiyet;

      public  string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
       public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToLower(); }
        }
       public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value.ToLower(); }
        }
        public int YAS
        {
            get { return yaş; }
            set { yaş = Math.Abs(value); }
        }
        public char CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public kimlik()
        {
            ad = "";
            soyad = "";
            yaş = 18;
            cinsiyet = '#';
            memleket = "Van";
        }
    }
}
