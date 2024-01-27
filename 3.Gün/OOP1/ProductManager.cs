using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager // Ürünle ilgili operasyonlar >>> Ekleme, silme, güncelleme gibi
    {
        public void Add(Product product) // Product diye gönderdiğimiz class'ı product diye tutarız.
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}
