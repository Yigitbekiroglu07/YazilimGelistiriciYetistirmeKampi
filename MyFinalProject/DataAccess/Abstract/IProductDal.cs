using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal // Productla ilgili veritabanında yapılacak operasyonları içeren interface.
        
    {
        List<Product> GetAll(); //Ürünlerin hepsini getir
        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);  // Ürünleri kategoriye göre filtrele. Parametre >> camelCase
                        


    }
}
