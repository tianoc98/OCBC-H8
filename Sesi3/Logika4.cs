using System;

public class Logika4{
    
    public static void Main(string[] args){
        double nilai;
        Console.Write("NILAI : ");
        nilai = Convert.ToDouble(Console.ReadLine());

        if(nilai >= 85){
            Console.WriteLine(" KAMU MENDAPATKAN GRADE A");
        }else if(nilai >= 65){
            Console.WriteLine(" KAMU MENDAPATKAN GRADE B"); 
        }else if(nilai >= 45){
            Console.WriteLine(" KAMU MENDAPATKAN GRADE C");
        }else{
            Console.WriteLine(" KAMU MENDAPATKAN GRADE D");
        }
    }
}