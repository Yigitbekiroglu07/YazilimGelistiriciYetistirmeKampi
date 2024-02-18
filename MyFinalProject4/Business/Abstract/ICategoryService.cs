using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService // Kategoriyle ilgili dış dünyaya ne servis edilmesi gerekiyorsa o yazılır
    {
        List<Category> GetAll();

        Category GetById(int categoryid);   
    }
}
