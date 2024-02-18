﻿
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); 
        IDataResult<List<Product>> GetAllByCategoryId(int id); // Kategori Id'sine göre tümünü getir

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max); // Belli fiyat araalıklarındakini getir

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IDataResult<Product> GetById(int productId);

        IResults Add(Product product);


    }
}
