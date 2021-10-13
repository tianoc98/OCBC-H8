using System;

namespace Program2
{
    class Program:bilangan
    {
        public override void penjumlahanperkalian(){
            Console.WriteLine("overriding 2...>>>>>>>>>>>");
            Console.WriteLine("Hasil Pembagian angka{0} dan angka {1} = {2}",bilangan1,bilangan2,bilangan1/bilangan2);
            Console.WriteLine("Hasil Pengurangan angka {0} dan angka {1} = {2}",bilangan1,bilangan2,bilangan1-bilangan2);
        }
        static void Main(string[] args)
        {
            int stat = 0;
            while(stat != 1){
                Console.WriteLine("SELAMAT DATANG DI SESI 5");
                Console.WriteLine("1. Pesawat Tempur");
                Console.WriteLine("2. Overloading");
                Console.WriteLine("3. Bilangan");
                Console.WriteLine("4. About Me");
                Console.WriteLine("5. Exit");
                Console.Write("SILAHKAN PILIH MENU = ");
                int pilih = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                switch(pilih){
                    case 1:{
                        Pesawat pswt1 = new Pesawat();
                        PesawatTempur tempur1 = new PesawatTempur();
                        Console.WriteLine("MASUKAN NAMA PESAWAT ");
                        pswt1.nama = Console.ReadLine(); 
                        Console.WriteLine("MASUKAN KETINGGIAN = ");
                        pswt1.setKetinggian = Console.ReadLine();
                        Console.WriteLine("MASUKAN JUMLAH PENUMPANG = ");
                        pswt1.setJumlahPenumpang = int.Parse(Console.ReadLine());
                        Console.WriteLine("MASUKAN JUMLAH RODA = ");
                        pswt1.setJumlahRoda = int.Parse(Console.ReadLine());
                        //=====================================================//
                        Console.WriteLine("MASUKAN NAMA PESAWAT TEMPUR =");
                        tempur1.nama = Console.ReadLine(); 
                        Console.WriteLine("MASUKAN KETINGGIAN = ");
                        tempur1.setKetinggian = Console.ReadLine();
                        Console.WriteLine("MASUKAN JUMLAH PENUMPANG = ");
                        tempur1.setJumlahPenumpang = int.Parse(Console.ReadLine());
                        Console.WriteLine("MASUKAN JUMLAH RODA = ");
                        tempur1.setJumlahRoda = int.Parse(Console.ReadLine());

                        pswt1.terbang();
                        pswt1.sudahterbang();
                        tempur1.terbang();
                        Console.WriteLine(" ");
                        Console.WriteLine("INGIN KEMBALI KE MENU UTAMA? Y/N");
                        string ulang = Console.ReadLine();
                        ulang = ulang.ToLower();
                        if(ulang == "y"){
                            break;
                        }else{
                            stat = 1;
                            break;
                        }
                    }
                    case 2:{
                        Overloading ovr1 = new Overloading();
                        Console.WriteLine("MASUKAN NAMA ");
                        ovr1.nama = Console.ReadLine(); 
                        Console.WriteLine("MASUKAN NOMOR TELEPON = ");
                        ovr1.nomor_telepon = double.Parse(Console.ReadLine());
                        ovr1.print(ovr1.nama);
                        ovr1.print(ovr1.nomor_telepon);
                        Console.WriteLine(" ");
                        Console.WriteLine("INGIN KEMBALI KE MENU UTAMA? Y/N");
                        string ulang = Console.ReadLine();
                        ulang = ulang.ToLower();
                        if(ulang == "y"){
                            break;
                        }else{
                            stat = 1;
                            break;
                        }
                    }
                    case 3:{
                        bilangan over1 = new bilangan();
                        Console.WriteLine("MASUKAN NOMER 1 = ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("MASUKAN NOMER 2 = ");
                        int num2 = int.Parse(Console.ReadLine());
                        over1.abilangan(num1,num2);
                        over1.penjumlahanperkalian();
                        over1 = new Program();
                        Console.WriteLine("OVERRIDING");
                        Console.WriteLine("MASUKAN NOMER 1 = ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("MASUKAN NOMER 2 = ");
                        num2 = int.Parse(Console.ReadLine());
                        over1.abilangan(num1,num2);
                        over1.penjumlahanperkalian();
                        Console.WriteLine(" ");
                        Console.WriteLine("INGIN KEMBALI KE MENU UTAMA? Y/N");
                        string ulang = Console.ReadLine();
                        ulang = ulang.ToLower();
                        if(ulang == "y"){
                            break;
                        }else{
                            stat = 1;
                            break;
                        }

                    }
                    case 4:{
                        Console.WriteLine("ABOUT ME~");
                        Console.WriteLine("HALO NAMAKU SEPTYAN YEVTA IRAWAN BIASA DI PANGGIL TIAN");
                        Console.WriteLine("SETELAH MENGIKUTI BELAJAR C# DARI SESI 1 - 5 JUJUR SAJA SAYA MERASA TERMOTIVASI");
                        Console.WriteLine("KARENA SAYA BELUM MENGENAL SAMA SEKALI C# DAN TERNYATA LEBIH MUDAH DARI PADA MENGGUNAKAN JAVA");
                        Console.WriteLine("MENTOR NYA JUGA SANTAI DALAM MENGAJAR DAN MEMBUAT NYAMAN PESERTA NYA");
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("INGIN KEMBALI KE MENU UTAMA? Y/N");
                        string ulang = Console.ReadLine();
                        ulang = ulang.ToLower();
                        if(ulang == "y"){
                            break;
                        }else{
                            stat = 1;
                            break;
                        }
                    }
                    case 5:{
                        stat = 1;
                        break;
                    }
                }

            }

        }
    }
}
