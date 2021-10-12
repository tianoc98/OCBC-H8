using System;

public class HitungNilai3{
    public static void Main(string[] args){

        int nilai1,nilai2;

        Console.WriteLine(" INPUTKAN NILAI 1 = ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.WriteLine("INPUTKAN NILAI 2 = ");
        nilai2 = int.Parse(Console.ReadLine());
        Console.WriteLine("HASIL PERBANDINGAN");
        Console.WriteLine($"nilai 1 > nilai 2 =  {nilai1>nilai2}");
        Console.WriteLine($"nilai 1 < nilai 2 =  {nilai1<nilai2}");
        Console.WriteLine($"nilai 1 >= nilai 2 =  {nilai1>=nilai2}");
        Console.WriteLine($"nilai 1 <= nilai 2 =  {nilai1<=nilai2}");
        Console.WriteLine($"nilai 1 == nilai 2 =  {nilai1==nilai2}");
        Console.WriteLine($"nilai 1 != nilai 2 =  {nilai1!=nilai2}");

    }
}