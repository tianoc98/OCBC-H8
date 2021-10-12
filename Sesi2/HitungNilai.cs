using System;


public class HitungNilai{

    public static void Main(string[] args){

        double pertama,kedua,ketiga,total;
        double avg;
        Console.WriteLine("===========Menghitung Nilai==============");
        Console.WriteLine("MASUKAN NILAI PERTAMA = ");
        pertama = double.Parse(Console.ReadLine());
        Console.WriteLine("MASUKAN NILAI PERTAMA = ");
        kedua = double.Parse(Console.ReadLine());
        Console.WriteLine("MASUKAN NILAI ketiga = ");
        ketiga = double.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        avg = total / 3.0;
        
        Console.WriteLine($"TOTAL = {total}");
        Console.WriteLine($"AVG = {avg}");

    }
}