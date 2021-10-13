using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();
            Console.WriteLine("INPUTKAN MERK = ");
            laptop1.merk = Console.ReadLine();
            Console.WriteLine("INPUTKAN RAM = ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("INPUTKAN MEMORY = ");
            laptop1.memory = int.Parse(Console.ReadLine());

            laptop1.Cetak();
        }
    }
}
