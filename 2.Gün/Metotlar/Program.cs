using System;
namespace Metotlar;

class Program
{
    static void Main(String[] args)
    {
       /* string productname = "Elma";
        double fiyat = 15;
        string acıklama = "Amasya elması"; */

        Urun urun1 = new Urun(); // dizi yerine class oluşturduğumuz zaman o ürünün tüm özelliklerini
        // tek çatı altında toplamış oluruz.
        // OLuşturulan classı kullanabilmek için onu newlemek gerekir.
        urun1.Id = 1;
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Açıklama = "Amasya elması";

        Urun urun2 = new Urun();
        urun2.Id = 2;
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Açıklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 }; // String gibi dizi oluşturabiliriz.
        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Id);
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Açıklama);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine("------------");
        }
        Console.WriteLine("---------Metodlar---------");
        SepetManager sepetManager = new SepetManager(); //Class'ı çağırmak için onu newlemek gerek.
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle2("Armut", "Yeşil Armut", 10);
    }

}
