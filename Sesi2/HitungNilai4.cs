using System;

public class HitungNilai4{

    public static void Main(string[] args){

        int looping = 0;
        while(looping != 1){
            Console.WriteLine("MASUKAN UMUR = ");
            int umur = int.Parse(Console.ReadLine());
            Console.WriteLine("PASSWORD = ");
            string pass = Console.ReadLine();
            bool isAdult = umur > 18;
            bool isPasswordValid = pass == "OCBC";
            
            if(isAdult && isPasswordValid){
                Console.WriteLine("WELCOME TO OCBC ");
                looping = 1;
            }else{
                Console.WriteLine("SORRY TRY AGAIN!");
            }
        }
        
    }
}