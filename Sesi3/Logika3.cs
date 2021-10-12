using System;

public class Logika3{

    public static void Main(string[] args){
        string username,password;

        Console.WriteLine("MASUKAN USERNAME !!! ");
        username = Console.ReadLine();
        Console.WriteLine("MASUKAN PASSWORD !!! ");
        password = Console.ReadLine();

        if(username == "ocbc" && password == "bootcamp"){
            Console.WriteLine("SUKSES LOGIN!");
        }else{
            Console.WriteLine("USERNAME / PASSWORD ANDA SALAH !!!");
        }
    }
}