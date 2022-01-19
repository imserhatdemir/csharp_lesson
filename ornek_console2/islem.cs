using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_console2
{
    class islem
    {
        public int topla(int s1, int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("[TOPLAMI:"+ s3+"]");
            return s3;
        }
        public int carp(int a,int b)
        {
            int sonuc = a*b;
            Console.WriteLine("[ÇARPIMI:" + sonuc+"]");
            return sonuc;
        }
    }
}
