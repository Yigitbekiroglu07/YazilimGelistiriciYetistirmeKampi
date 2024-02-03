using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class NorthwindContext:DbContext // DbContext >> Entitiy Framework ile geldi

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Projenin hangi veritabanıyla ilişkili olduğunu belirtir.
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=SSPI"); // SQL Server'a nasıl bağlanacağını bellirme
        }
        public DbSet<Product> Products { get; set; } // Hangi Claas'ın hangi tabloya karşılık geldiğini bulma

        public DbSet<Category> Categories { get; set; } // Hangi Claas'ın hangi tabloya karşılık geldiğini bulma

        public DbSet<Customer> Customers { get; set; } // Hangi Claas'ın hangi tabloya karşılık geldiğini bulma


    }
    


}
