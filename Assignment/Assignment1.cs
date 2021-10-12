using System;

public class Assignment1{
    public static void Main(string[] args){
        Console.WriteLine("==================================================");
        Console.WriteLine("Nama : Septyan Yevta Irawan");
        Console.WriteLine("No Peserta :FSDO001ONL015");
        Console.WriteLine("Domisili : Pati");
        Console.WriteLine("=====MAIN MENU ASSIGNMENT 1=====");
        Console.WriteLine("1. Tugas-1 ( Membuat Segitiga Alfabet )");
        Console.WriteLine("2. Tugas-2 ( Membuat Segitiga Angka )");
        Console.WriteLine("3. Tugas-3 ( Membuat Faktorial )");
        Console.WriteLine("4. Tugas-4 ( Membuat Reverse String / number )");
        Console.WriteLine("5. Tugas-5 ( Converter Angka To String )");
        Console.WriteLine("6. Exit");
        int flag = 0; // Untuk Savepoint

        while(flag != 1){
            Console.Write("PILIH MENU !!! = ");
            int pilih = int.Parse(Console.ReadLine());
            switch(pilih){
                case 1:{
                    Console.Write("MASUKAN TINGGI = ");
                    int t = int.Parse(Console.ReadLine());
                    int i,j,k;
                    for(i = 0; i <= t; i++){
                        for(j = t;j > i ; j--){
                            Console.Write(" ");
                        }
                        char chara = 'a';
                        char temp = 'a';
                        int checkingz = 0;
                        for(k = 1;k<(i*2);k++){
                            if(k > i){
                                if(checkingz==0){
                                    temp--;
                                    checkingz++;
                                }
                                temp--;
                                Console.Write(temp);
                            }else{
                                Console.Write(chara);
                                chara++;
                                temp = chara;
                            }
                            
                        }
                        Console.WriteLine(" ");
                    }
                    flag = 1;
                    break;
                }
                case 2:{
                    Console.Write("MASUKAN TINGGI = ");
                    int t = int.Parse(Console.ReadLine());
                    int i,j,k;
                    for(i = 0; i <= t; i++){
                        for(j = t;j > i ; j--){
                            Console.Write(" ");
                        }
                        int angka = 1;
                        int temp = 0;
                        for(k = 1;k<(i*2);k++){
                            if(k > i){
                                temp--;
                                Console.Write(temp);
                            }else{
                                Console.Write(angka);
                                angka++;
                                temp = angka -1;
                            }
                            
                        }
                        Console.WriteLine(" ");
                    }
                    flag = 1;
                    break;

                }
                case 3:{
                    Console.WriteLine("MASUKAN ANGKA YANG INGIN DI FAKTORIALKAN ! ");
                    int angka = int.Parse(Console.ReadLine());
                    int jumlah = 1;
                    for(int i = 1;i<=angka;i++){
                        jumlah = jumlah * i ;
                    }
                    for(int i = 1;i<=angka;i++){
                        if(i == angka){
                        Console.Write($"{i} = {jumlah}");
                        }else{
                        Console.Write($"{i} X ");
                        }
                    }
                    flag = 1;
                    break;

                }
                case 4:{
                    Console.WriteLine("MASUKAN SUSUNAN KATA / STRING / NOMER = ");
                    string str = Console.ReadLine();
                    int getlast = str.Length;
                    char[] arrstr = new char[str.Length];
                    for(int i = 0;i<str.Length;i++){
                        arrstr[i] = str[i];
                    }
                    for(int c = 0 ;c < str.Length;c++){
                        Console.Write(arrstr[getlast-1]);
                        getlast--;
                    }
                    flag = 1;
                    break;

                }
                case 5:{
                    Console.WriteLine("MASUKAN INPUT ANGKA ");
                    string number = Console.ReadLine();
                    string[] arrstr = new string [number.Length];
                    for(int i = 0;i<number.Length;i++){
                        string temporary = number[i].ToString();
                        int numbers = int.Parse(temporary);
                        if(numbers == 1){
                            arrstr[i] = "ONE";
                        }else if(numbers == 2){
                            arrstr[i] = "TWO";
                        }else if(numbers == 3){
                            arrstr[i] = "THREE";
                        }else if(numbers == 4){
                            arrstr[i] = "FOUR";
                        }else if(numbers == 5){
                            arrstr[i] = "FIVE";
                        }else if(numbers == 6){
                            arrstr[i] = "SIX";
                        }else if(numbers == 7){
                            arrstr[i] = "SEVEN";
                        }else if(numbers == 8){
                            arrstr[i] = "EIGHT";
                        }else if(numbers == 9){
                            arrstr[i] = "NINE";
                        }
                    }
                    for(int j = 0;j<number.Length;j++){
                        Console.Write(arrstr[j]+" ");
                    }
                    flag = 1;
                    break;
                }
                case 6:{
                    flag = 1;
                    break;
                }
                default:
                    Console.WriteLine("WRONG INPUT , PLEASE TRY AGAIN !");
                    break;
            }
        }
    }
}