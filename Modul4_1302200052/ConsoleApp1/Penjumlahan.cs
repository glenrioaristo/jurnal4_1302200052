using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302200052
{
    internal class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T data1, T data2, T data3)
        {
            dynamic angka1 = data1;
            dynamic angka2 = data2;
            dynamic angka3 = data3;

            Console.WriteLine(angka1 + angka2 + angka3 + "\n");

        }
    }
}
