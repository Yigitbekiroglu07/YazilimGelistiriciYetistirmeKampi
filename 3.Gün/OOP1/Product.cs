using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{   
    // Snippet >>> Hızlı Kod
     class Product // Classlar, özellik tutucudur.
    {
        public int Id { get; set; }

        public int CategoryId { get; set; } // Hangi kategoriye ait olduğunu belirtir

        public string ProductName { get; set; }    
        
        public double UnitPrice { get; set; }  

        public int UnitsInStocks { get; set; }  // Stok adedi

        
    }
}
