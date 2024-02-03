using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) // İşi bitince bellekten atılacak 
            {
                var addedEntitiy = context.Entry(entity); // Referansı yakala
                addedEntitiy.State = EntityState.Added; // Eklenecek nesne
                context.SaveChanges(); // Ekle

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntitiy = context.Entry(entity);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter) // Tek data getir
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null) //Lambda
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntitiy = context.Entry(entity);
                updatedEntitiy.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
