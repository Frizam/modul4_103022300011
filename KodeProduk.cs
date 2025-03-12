using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300011
{
    internal class KodeProduk
    {
        public enum ProdukElektronik { //enum untuk merepresentasikan Produk Elektronik
            Laptop,
            Smartphone,
            Tablet,
            Headset,
            Keyboard,
            Mouse,
            Printer,
            Monitor,
            Smartwatch,
            Kamera
        }

        //Method untuk mengembalikan kode produk dari tabel produk elektronik diatas
        public static string getKodeProduk(ProdukElektronik produkElektronik) {
            string[] kodeProduk = { "E100", "E101", "E102", "E103", 
                "E104", "E105", "E106", "E107", "E108", "E109" };
            
            return kodeProduk[(int)produkElektronik];
        }

    }
}
