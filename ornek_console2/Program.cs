using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_console2
{
    class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            int sayi1, sayi2;
            Console.Write("1.sayiyi giriniz:");
            sayi1 =Convert.ToInt32( Console.ReadLine());
            Console.Write("2.sayiyi giriniz:");
            sayi2 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine("***********************************");
            isl.topla(sayi1,sayi2);
           
         
            isl.carp(sayi1,sayi2);
            Console.WriteLine("***********************************");
            Console.Read();
        }
    }
}
