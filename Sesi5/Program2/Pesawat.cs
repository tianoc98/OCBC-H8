using System;

public class Pesawat{

    public string nama;
    private string ketinggian;
    protected int jumlahpenumpang;
    protected int jumlahroda;

    public string setKetinggian{
        get { return ketinggian;}
        set { ketinggian = value;}
    }
    public int setJumlahPenumpang{
        get { return jumlahpenumpang;}
        set { jumlahpenumpang = value;}
    }
    public int setJumlahRoda{
        get { return jumlahroda;}
        set { jumlahroda = value;}
    }

    public void terbang(){
        Console.WriteLine("Pesawat dengan nama {0}, sedang take off ",this.nama);
    }

    public void sudahterbang(){
        Console.WriteLine("Pesawat Sekarang berada pada ketinggian {0}",this.ketinggian);
    }
}