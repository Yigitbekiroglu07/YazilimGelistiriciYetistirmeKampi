using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class GercekMusteri:Musteri // Gerçek müşteri bir mmüşteridir
        // Miras >>> Inheritance
    {

        public string TcNo { get; set; }
        // Eğer rakamlarla matematiksekl işlem yoksa 
        // metinsel ifade için string daha mantıklı olur.
        public string Adi { get; set; }
        public string SoyAdi { get; set; }

        

    }
}
