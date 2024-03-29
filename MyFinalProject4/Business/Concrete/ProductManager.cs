﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{   
    
    public class ProductManager : IProductService
    {
        IProductDal _productDal; // Soyutları çağırır, constructor yaparız

        public ProductManager(IProductDal productDal) 
        {
            _productDal = productDal;
        }

        public IResults Add(Product product)
        {
            // Business Code >> İş kodları buraya yazılır.
            if(product.ProductName.Length < 2)
            {
                // magic strings >> Stringleri ayrı ayrı yazma
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }       

        public IDataResult<List<Product>> GetAll()
        {
            // İş Kodları
              if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
              return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);  
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=> p.CategoryId == id));  

        }

        public IDataResult<Product> GetById(int productId)
        {
           return new SuccessDataResult<Product>(_productDal.Get(p=>  p.ProductId == productId));   
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
           return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=> p.UnitPrice >= min && p.UnitPrice <= max)); // İki fiyat arasındaki kodlar    
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}
