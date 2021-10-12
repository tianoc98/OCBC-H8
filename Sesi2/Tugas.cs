using System;

public class Tugas{

    public static void Main(string[] args){

        int looping = 0;
        while(looping != 1){
            Console.WriteLine("USERNAME = ");
            string username = Console.ReadLine();
            Console.WriteLine("MASUKAN JENIS KELAMIN = ");
            string jk = Console.ReadLine();
            Console.WriteLine("MASUKAN STATUS NIKAH = ");
            string nikah = Console.ReadLine();
            Console.WriteLine("MASUKAN UMUR = ");
            int umur = int.Parse(Console.ReadLine());
            Console.WriteLine("PASSWORD = ");
            string pass = Console.ReadLine();
            bool isAdult = umur > 18;
            bool isPasswordValid = pass == "OCBC";
            bool isUsername = username == "Tian";
            if(isAdult && isPasswordValid && isUsername){
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
                
                Console.WriteLine("WELCOME TO OCBC ");
                Console.WriteLine("BIODATA");
                Console.WriteLine($"Nama = {username}");
                Console.WriteLine($"Umur = {umur}");
                Console.WriteLine($"Jenis Kelamin = {jk}");
                Console.WriteLine($"Status Nikah = {nikah}");
                Console.WriteLine($"Total Nilai = {total}");
                Console.WriteLine($"Rata-Rata = {avg}");
                looping = 1;
            }else{
                Console.WriteLine("SORRY TRY AGAIN!");
            }
        }
    }
}