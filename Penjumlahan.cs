using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210070
{
    internal class Penjumlahan<T>
    {
        private T a;
        private T b;
        private T c;
        public void JumlahTigaAngka(T a, T b, T c)
        {
            dynamic hasil = 0;

            hasil = hasil + a ;
            hasil = hasil + b ;
            hasil = hasil + c ; 

            Console.WriteLine("Hasil penjumlahan dari " + a + " "+ b + " " + c + " adalah " + hasil);
        }
    }
}
