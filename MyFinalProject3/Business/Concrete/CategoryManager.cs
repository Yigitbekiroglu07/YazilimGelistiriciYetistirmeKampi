using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; // Business katmanının DataAccess'i kullandığı kısım

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }



        // İş Kodları
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
        // Select * from Categories where CategoryId = 3

        public Category GetById(int categoryid)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryid);

        }
    }

}
