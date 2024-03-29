﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); 
        List<Product> GetAllByCategoryId(int id); // Kategori Id'sine göre tümünü getir

        List<Product> GetByUnitPrice(decimal min, decimal max); // Belli fiyat araalıklarındakini getir
                                                  
    }
}
