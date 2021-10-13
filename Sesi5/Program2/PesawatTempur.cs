using System;

public class PesawatTempur:Pesawat{

    public void terbang(){
        Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1} berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} Akan meledakan senjata",this.nama,this.jumlahroda,this.setKetinggian,this.jumlahpenumpang);
    }
}