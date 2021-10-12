using System;

public class Data2{
    public static void Main(string[] args){
        string[] contoh = new string[4]
        {
            "motherboard","processor","power supply","Video Card"
        };
        Console.WriteLine("Menampilkan Semua data dalam array ");
        Console.WriteLine(" ");

        foreach(string contoh1 in contoh){
            Console.WriteLine(contoh1);
        }

        Console.Write("Press Any key To Continue");
    }
}