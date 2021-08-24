abstract class Cu{ // trừu tượng
    
    abstract void TiengKeu();

    void NhapThongTin(){
    }
    void XuatThongTin(){}
}

class Moi : Cu
{
    override void TiengKeu(){
        Console.WriteLine("Moi");
    }
    //phương thức - con ruột
    public void PhuongThuc(){
        Console.WriteLine("Phương thức con ruột");
    }
}
class Program{
    //hàm - con ghẻ - phải có static
    public static void Ham(){
        Console.WriteLine("Hàm");
    }
    
    
    static void Main(string[] args){
        Moi moi = new Moi();
        moi.PhuongThuc();

        Ham();
    }
}