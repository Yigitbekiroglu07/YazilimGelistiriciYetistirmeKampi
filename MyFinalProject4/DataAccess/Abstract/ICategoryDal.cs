﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        /*List<Category> GetAll(); //Ürünlerin hepsini getir
         
        void Add(Category category );

        void Update(Category category );

        void Delete(Category category);

        List<Category> GetAllByCategory(int categoryId);  // Ürünleri kategoriye göre filtrele. Parametre >> camelCase */
    }
}
