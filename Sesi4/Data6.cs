using System;

public class Data6{

    public static void Main(string[] args){
        int[] angka = new int[10];
        Console.WriteLine("Panjang Array Angka Adalah "+angka.Length);

        for(int i = 0;i<angka.Length;i++){
            angka[i] = i*i;
        }
        Console.Write("BERIKUT ADALAH ARRAY ANGKA : ");
        for(int i =0;i<angka.Length;i++){
            Console.Write(angka[i]+" ");
            Console.WriteLine();
        }
    }
}