using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "foxi";
            int total1 = 10,total2 = 7,total3 = 12;
            double price1 = 10000,price2 = 5000,price3 = 20000;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Septyan Yevta Irawan");
            Console.WriteLine("Selamat Datang Di Program OCBC");
            Console.WriteLine("Tahap 1 Saya Akan Belajar C#");
            int total_item = total1 + total2 + total3;
            double price_item1 = total1 * price1,
            price_item2=total2,
            price_item3 = total3;
            double total_price1 = price1*total1,
            total_price2 = price2*total2,
            total_price3 = price3*total3;
            double allprice = price1 + price2 + price3;

            Console.WriteLine("Nama Custommer = "+name);
            Console.WriteLine("Harga Barang 1 = "+price1+" Jumlah Barang 1 = "+total1+" Total Harga = "+total_price1);
            Console.WriteLine("Harga Barang 2 = "+price2+" Jumlah Barang 2 = "+total2+" Total Harga = "+total_price2);
            Console.WriteLine("Harga Barang 3 = "+price3+" Jumlah Barang 3 = "+total3+" Total Harga = "+total_price3);
            Console.WriteLine("Total Barang = "+total_item);
            Console.WriteLine("Total Harga = "+allprice);
        }
    }
}
