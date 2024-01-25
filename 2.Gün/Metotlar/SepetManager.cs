using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun aa) //Urun tiptir, urun ise aşağıda yazarken kullanılacak isimdir.
        {
            Console.WriteLine("Sepete eklendi : " +aa.Adi);
        }
        public void Ekle2(string urunAdi, string açıklama, double fiyat )
        // Üstteki gibi yerine, class oluşturmadan bu şeiklde de yapılabilir.
        // ancak bu kullanım pek yararlı değil, 
        // sebebi yeni bir parametre girilmesi istendiğinde Program.cs'de her bir fonksiyonu değişitmemiz gerekecek.
        {
            Console.WriteLine("Sepete eklendi : " +urunAdi);
        }
    }
}
