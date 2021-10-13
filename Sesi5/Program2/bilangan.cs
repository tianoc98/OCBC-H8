using System;

public class bilangan{

    public int bilangan1, bilangan2;

    public void abilangan(int angka1,int angka2){
        bilangan1 = angka1;
        bilangan2 = angka2;
    }

    public virtual void penjumlahanperkalian(){
        Console.WriteLine("OVERRIDING 1.............>>>>>>");
        Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1} = {2}",bilangan1,bilangan2,bilangan1+bilangan2);
        Console.WriteLine("Hasil Perkalian angka {0} dan angka {1} = {2}",bilangan1,bilangan2,bilangan1*bilangan2);
    }
}