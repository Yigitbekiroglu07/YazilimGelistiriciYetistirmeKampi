using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // Veritabanı, Global değişken
        public InMemoryProductDal()
        {
            // Oracle, SQLServer, PostgreSQL, MongoDB'den geliyor gibi simule etme
            _products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, ProductName = "Bardak", UnitPrice = 15, UnitInStock=15},
                new Product{ProductId=2, CategoryId=2, ProductName = "Kamera", UnitPrice = 500, UnitInStock=3},
                new Product{ProductId=3, CategoryId=3, ProductName = "Telefon", UnitPrice = 1500, UnitInStock=2},
                new Product{ProductId=4, CategoryId=4, ProductName = "Klavye", UnitPrice = 150, UnitInStock=65},
                new Product{ProductId=5, CategoryId=5, ProductName = "Fare", UnitPrice = 85, UnitInStock=1},

            };        
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)

        {
            /* Product productToDelete = null; // 43. satırda hata vermesin diye null'a eşitle
            foreach (var p in _products) //Listeyi tek tek dolaşmak için
            {
                if(product.ProductId == p.ProductId)
                {
                    productToDelete = p;    
                }
            }
            _products.Remove(productToDelete); */
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId); // _products'ı tek tek dolaşmak için
            _products.Remove(productToDelete);  
        }

        public List<Product> GetAll() // Veritabanındaki datayı business'a verme işlemi. Bu yüzden liste kullanılır. Değer döndürülür.
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList(); 
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün ID'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;  
            productToUpdate.CategoryId = product.CategoryId;    
            productToUpdate.UnitPrice = product.UnitPrice;  
            productToUpdate.UnitInStock = product.UnitInStock;  
        }
    }
}
