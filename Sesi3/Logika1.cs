using System;

public class Logika1{
    public static void Main(string[] args){

        int a,b;
        Console.WriteLine("MASUKAN NOMOR A = ");
        a =  int.Parse(Console.ReadLine());
        Console.WriteLine("MASUKAN NOMOR B = ");
        b =  int.Parse(Console.ReadLine());

        if(a > b){
            Console.WriteLine(" NOMOR A LEBIH BESAR DARI PADA B");
        }else{
            Console.WriteLine(" NOMOR B LEBIH BESAR DARI PADA A");
        }
    }
}