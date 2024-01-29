using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3

      // Method injection
{
     class BasvuruManager // Başvuru yapanların işlemlerinin olduğu class
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices ) // Elimizde tüm kredi türlerinini implemente eden IKrediManager'ı 
            // kullanmayılız çünkü hepsinin referansını tutuyor.
        {
            // Başvuran bilgilerini değerlendirme
            // Kredi hesaplama
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        // Kredi çeşitlerini söyleyebilmek için liste oluşturmak gerek. Türü de referans tutucu IKrediManager olmalı.
        {
            foreach (var kredi in krediler) // foreach'le dönme sebebi elimizde liste olması.
            {
                kredi.Hesapla();
            }
        }
    }
}
