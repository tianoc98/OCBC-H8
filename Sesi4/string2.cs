using System;

public class string2{

    public static void Main(string[] args){

        string str1 = "UNTUK PEMROGRAMAN .NET , C# adalah #1.";
        string str2 = "UNTUK PEMROGRAMAN .NET , C# adalah #1.";
        string str3 = "String C# sangat tangguh";

        string stratas,strbawah;
        int hasil,idx;

        Console.WriteLine("str1 "+str1);
        Console.WriteLine("Panjang str1 "+str1.Length);
        strbawah = str1.ToLower();
        stratas = str1.ToUpper();
        Console.WriteLine("HURUF KECIL = "+strbawah);
        Console.WriteLine("HURUF BESAR = "+stratas);

        Console.WriteLine("Menampilkan str1, char demi char");
        for(int i =0;i<str1.Length;i++){
            Console.WriteLine(str1[i]);
        }

        if(str1 == str2){
            Console.WriteLine("str1==str2");
        }else{
            Console.WriteLine("str1 != str2");
        }

        if(str1 == str3){
            Console.WriteLine("str1==str3");
        }else{
            Console.WriteLine("str1 != str3");
        }

        hasil = string.Compare(str1,str3,StringComparison.CurrentCulture);
        if(hasil==0){
            Console.WriteLine("str1 dan str3 sama");
        }else if(hasil<0){
            Console.WriteLine("str 1 kurang dari str3");
        }else{
            Console.WriteLine("str1 lebih besar dari str3");
        }

        str2 = "Satu Dua Tiga Satu";

        idx = str2.IndexOf("Satu",StringComparison.Ordinal);
        Console.WriteLine("INDEX KEMUNCULAN PERTAMA DARI SATU "+idx);

        idx = str2.LastIndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("INDEX KEMUNCULAN TERAKHIR DARI SATU = "+idx);
    }
}