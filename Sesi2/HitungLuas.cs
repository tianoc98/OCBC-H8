using System;

public class HitungLuas
{
    public static void Main(string[] args)
    {
        int panjang = 20;
        double lebar = 2.3;

        double luas = panjang * lebar;

        Console.WriteLine($"Panjang dari persegi panjang adalah {panjang} dan lebar nya adalah {lebar}");
        Console.WriteLine("Rumus Dari Luas adalah Panjang X Lebar");
        Console.WriteLine($"{panjang} X {lebar}");
        Console.WriteLine($"Luas Persegi panjang tersebut adalah = {luas}");
        
    }
}