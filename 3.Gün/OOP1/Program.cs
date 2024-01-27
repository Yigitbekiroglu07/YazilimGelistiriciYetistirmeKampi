using System;
namespace OOP1
{
    class Program
    {
        static void Main(String[] args)
        {
            Product product1 = new Product();  
            product1.Id = 1;
            product1.CategoryId = 2; // 2 numara mobilyaya karşılık gelsin.
            product1.ProductName = "Masa";  
            product1.UnitPrice = 500;        
            product1.UnitsInStocks = 3;    

            Product product2 = new Product {Id = 2, CategoryId = 5, ProductName = "Kalem",
            UnitPrice = 35};   // Bu şekilde de yazılabilir.
               
            ProductManager productManager = new ProductManager();
            productManager.Add(product1); // product1'in tüm özelliklerini ProductManager sınıfını Add fonksiyonuna ekle.

        }
    }
}
