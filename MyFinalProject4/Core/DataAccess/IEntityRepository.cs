using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // generic constraint
    // class: Referans tip
    // Entity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new(): New'lenebilir olmalı. Interfaceler newlenmez o yüzden Entity yazarken hata vermez.
    public interface IEntityRepository<T> where T : class,IEntitiy, new() // T sadece referans tip olabilir

    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Seçtiğin tipin hepsini getir, Expression >>> Filtreleme

        T Get(Expression<Func<T, bool>> filter = null); // Tek bir data getirmek için
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        // List<T> GetAllByCategory(int categoryId);  // Seçtiğin tipe göre filtrele. Parametre >> camelCase
    }
}
