using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_yapıcı_metot2
{
    class Program
    {
        static void Main(string[] args)
        {
            kimlik kml = new kimlik();
            kml.AD = "SERHAT";
            kml.SOYAD = "demir";
            kml.MEMLEKET = "Van";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);
            Console.Read();
        }
    }
}
