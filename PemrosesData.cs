using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod5_103022330036
{
    internal class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
        {
            dynamic a1 = (dynamic)nilai1;
            dynamic a2 = (dynamic)nilai2;
            dynamic a3 = (dynamic)nilai3;

            if (a1 > a2 && a1 > a3)
            {
                Console.WriteLine("Nilai terbesar yaitu " + nilai1);
            }
            if (a2 > a3 && a2 > a1)
            {

                Console.WriteLine("Nilai terbesar yaitu " + nilai2);
            }

            if (a3 > a1 && a3 > a2)
            {
                Console.WriteLine("Nilai terbesar yaitu " + nilai3);
            }

        }
        static void Main(string[] args)
        {
            PemrosesData data = new PemrosesData();
            int nim = 6;
            int nim2 = 7;
            int nim3 = 8;
            data.DapatkanNilaiTerbesar(nim, nim2, nim3);
        }

    }
}
