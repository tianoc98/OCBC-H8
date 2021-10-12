using System;

public class Logika8{

    public static void Main(string[] args){
        int pilih,batas,start;
        Console.WriteLine("1. PENJUMLAHAN");
        Console.WriteLine("2. PENGURANGAN");
        Console.WriteLine("3. PEMBAGIAN");
        Console.WriteLine("4. PERKALIAN");
        Console.Write("PILIH MENU! = ");
        pilih = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.Write("MASUKAN START ! = ");
        start = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.Write("MASUKAN END ! = ");
        batas = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        switch(pilih){
            case 1:{
                for(int i = 1;i<= batas;i++){
                    Console.WriteLine($"{i} + {start} = {i+start}");
                }
                break;
            }
            case 2:{
                for(int i = 1;i<= batas;i++){
                    Console.WriteLine($"{i} - {start} = {i-start}");
                }
                break;
            }
            case 3:{
                for(int i = 1;i<= batas;i++){
                    Console.WriteLine($"{i} / {start} = {i/start}");
                }
                break;
            }
            case 4:{
                for(int i = 1;i<= batas;i++){
                    Console.WriteLine($"{i} * {start} = {i*start}");
                }
                break;
            }
            default:
                Console.WriteLine("SALAH INPUT");
                break;
        }
    }
}