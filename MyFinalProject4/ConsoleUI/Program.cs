using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.ComponentModel.Design;

namespace ConsoleUI
{
    class Program
    {
        static void Main(String[] args)
        {
            ProductTest();
            // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal()); // İçine hangi veri yöntemiyle çalıştığı yazılır
            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data) // Business katmanından tüm ürünler alınır
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            }

           
        }
    }

