using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_yapici_metot
{
    class ogrenci
    {
        public ogrenci(string ad,string soyad,int sınıf,string bölüm)
        {
            
            Console.WriteLine("AD:"+ad);
            Console.WriteLine("SOYAD:" + soyad);
            Console.WriteLine("SINIF:" + sınıf);
            Console.WriteLine("BÖLÜM:" + bölüm);

        }
    }
}
