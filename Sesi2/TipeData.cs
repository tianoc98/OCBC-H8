using System;

public class TipeData{

    public static void Main(string[] args){
        string nama,alamat;
        int umur;

        Console.WriteLine("PROGRAM PENDAFTARAN PENDUDUK");
        Console.WriteLine("MASUKAN NAMA ANDA = ");
        nama = Console.ReadLine();
        Console.WriteLine("MASUKAN UMUR ANDA = ");
        umur = int.Parse(Console.ReadLine());
        Console.WriteLine("MASUKAN ALAMAT ANDA = ");
        alamat = Console.ReadLine();

        Console.WriteLine("DATA TELAH TERSIMPAN");
        Console.WriteLine("BERIKUT ADALAH DATA NYA !");
        Console.WriteLine($"Nama = {nama}");
        Console.WriteLine($"umur = {umur} Tahun");
        Console.WriteLine($"alamat = {alamat}");

        Console.WriteLine("TERIMA KASIH TELAH MENDAFTAR!");

    }
}