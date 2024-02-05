using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product> // Ürüne ait özel operasyonlar, Productla ilgili veritabanında yapılacak operasyonları içeren interface.
        
    {
        List<ProductDetailDto> GetProductDetails(); // Ürüne ait detaylar

    }
}
