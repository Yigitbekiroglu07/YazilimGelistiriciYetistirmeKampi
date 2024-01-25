using System;
namespace kampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            string kategoriEtiketi = "Kategori";
            bool SistemeGirisYapmisMi = false;
            double faizOranı = 1.45;
            int ogrenciSayisi = 32500;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}

