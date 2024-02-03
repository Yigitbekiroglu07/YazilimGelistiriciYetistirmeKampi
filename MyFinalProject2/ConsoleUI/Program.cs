using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(String[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal()); // İçine hangi veri yöntemiyle çalıştığı yazılır
            foreach (var product in productManager.GetByUnitPrice(50,100)) // Business katmanından tüm ürünler alınır
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
