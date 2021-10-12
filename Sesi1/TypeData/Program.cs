using System;

namespace TypeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname,lname,alamat,tanggal;

            int umur;

            Console.WriteLine("Hello World!");
            Console.WriteLine("ENTER UR FIRST NAME = ");
            fname = Console.ReadLine();

            Console.WriteLine("ENTER UR LAST NAME = ");
            lname = Console.ReadLine();

            Console.WriteLine("ENTER UR Age = ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER UR Address = ");
            alamat = Console.ReadLine();

            Console.WriteLine("ENTER UR Date of Birth = ");
            tanggal = Console.ReadLine();

            Console.WriteLine("Ur Name Is "+fname+" "+lname+" "+umur+" years old ur addres in "+alamat+" and ur birthday is "+tanggal);
        }
    }
}
