using System;
namespace OOP2;

class Program
{
    static void Main(String[] args)
    {
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;    
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Yiğit Alperen";
        musteri1.SoyAdi = "Bekiroğlu";  
        musteri1.TcNo = "12345678910";    

        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "54321";
        musteri2.SirketAdi = "Kodlama.io";
        musteri2.VergiNo = "12345"; 

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2 ); 
        
    }
}