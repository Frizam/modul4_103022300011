// See https://aka.ms/new-console-template for more information
using modul4_103022300011;
using static modul4_103022300011.KodeProduk;

Console.WriteLine("Masukan nama produk:");
string input  = Console.ReadLine();

//Untuk mengkonvert input string menjadi enum
if (Enum.TryParse(input, out KodeProduk.ProdukElektronik produk))
{
    string kodeProduk = KodeProduk.getKodeProduk(produk); //untuk menampung kode produk dari produk yang diinput
    Console.WriteLine("Kode Produk " + input + ": " + kodeProduk);
}
else {
    Console.WriteLine("Kode Produk " + input + " Tidak ditemukan"); //jika konvertan input string tidak ada di enum
}


FanLaptop fan = new FanLaptop(); //di set menjadi quiet disini

string command;

while (true) {
    Console.WriteLine("Masukan Perintah: ('Exit' untuk keluar program)");
    command = Console.ReadLine();

    if (command == "Exit")
    {
        Console.WriteLine("Selesai.");
        break;
    }
    else if (command == "Quiet Mode")
    {
        fan.QuietMode(); //Quiet mode diaktifkan
    }
    else if (command == "Balanced Mode")
    {
        fan.BalancedMode(); //Balanced mode diaktifkan
    }
    else if (command == "Turbo Mode")
    {
        fan.TurboMode(); //Turbo mode diaktifkan
    }
    else {
        Console.WriteLine("Input Perintah yang benar");
    }
}