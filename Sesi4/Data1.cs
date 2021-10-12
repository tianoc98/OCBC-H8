using System;

public class Data1{

    public static void Main(string[] args){

        int[] aAngka = new int[5];
        string[] anama = new string[] {"Joni","Meri","David"};
        object[] aObjek = {20.33,"Lorem Ipsum",DateTime.Now,true,'D'};
        Console.WriteLine("aObjek Array ");
        foreach(object datas in aObjek){
            Console.WriteLine(datas);
        }
        Console.WriteLine("Nama Array ");
        foreach(string anamas in anama ){
            Console.WriteLine(anamas);
        }
    }
}