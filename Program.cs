// See https://aka.ms/new-console-template for more information
using modul4_103022300011;
using static modul4_103022300011.KodeProduk;

Console.WriteLine("Masukan nama produk:");
string input  = Console.ReadLine();

//Untuk mengkonvert input string menjadi enum
if (Enum.TryParse(input, out KodeProduk.ProdukElektronik produk))
{
    string kodeProduk = KodeProduk.getKodeProduk(produk);
    Console.WriteLine("Kode Produk " + input + ": " + kodeProduk);
}
else {
    Console.WriteLine("Kode Produk " + input + " Tidak ditemukan"); //jika konvertan input string tidak ada di enum
}