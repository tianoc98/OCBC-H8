using System;

public class String3{

    public static void Main(string[] args){
        string[] str = {"ini","adalah","sebuah","test"};
        Console.WriteLine("array asli : ");

        for(int i = 0;i<str.Length;i++){
            Console.WriteLine(str[i]+" ");
        }

        str[1] = " Merupakan ";
        str[3] = "test, juga ";
        Console.WriteLine("Array termodifikasi ");
        for(int i=0;i<str.Length;i++){
            Console.Write(str[i]+" ");
        }
    }
}