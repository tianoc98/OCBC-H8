using System;

public class Logika2{

    public static void Main(string[] args){

        string nama;
        double nilai;
        string convertnilai;
        Console.WriteLine(" MASUKAN NAMA SISWA = ");
        nama = Console.ReadLine();
        Console.WriteLine("MASUKAN NILAI SISWA = ");
        nilai = double.Parse(Console.ReadLine());

        if (nilai < 60){
            convertnilai = "C";
        }else if(nilai < 80){
            convertnilai = "B";
        }else{
            convertnilai = "A";
        }

        Console.WriteLine($"SISWA {nama} MENDAPATKAN NILAI {convertnilai}");
    }
}