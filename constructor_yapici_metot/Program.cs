using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_yapici_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,t;
            int c;
            Console.WriteLine("*******HOŞGELDİNİZ*************");
            Console.Write("ADINIZI GİRİN;");
            a = Console.ReadLine();
            Console.Write("SOYADINIZI GİRİN;");
            b = Console.ReadLine();
            Console.Write("SINIFINIZI GİRİN;");
            c =Convert.ToInt32( Console.ReadLine());
            Console.Write("BÖLÜMÜNÜZÜ GİRİN;");
            t = Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("**************************");
            Console.WriteLine("\n");
            ogrenci ogr = new ogrenci(a,b,c,t);
            Console.WriteLine("\n");
            Console.WriteLine("**************************");
            Console.Read();
        }
    }
}
