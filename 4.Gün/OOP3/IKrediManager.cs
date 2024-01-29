using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager // Interface oluşturulma sebebi, Hesapla fonksiyonun tüm krediler
        // için farklı hesaplanma yöntemiyle hesaplanmasıdır. 
    {
         void Hesapla();

        void BirSeyYap();  
         

        
    }
}
