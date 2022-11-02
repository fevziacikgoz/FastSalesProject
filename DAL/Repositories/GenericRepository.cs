using DAL.Abstract;
using DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace DAL.Repositories
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        DatafarkContext d = new DatafarkContext();

        public T Delete(T t)
        {
            d.Remove(t);
            d.SaveChanges();
            return t;
        }

        public T GetBy(int id)
        {
            return d.Set<T>().Find(id);
        }

        public IQueryable<T> GetListAll(string[] including = null)
        {
            var query = d.Set<T>().AsQueryable();
            if (including != null)
                including.ToList().ForEach(include =>
                {
                    if (!string.IsNullOrEmpty(include))
                        query = query.Include(include.Trim());
                });
            return query;

        }


        public T Insert(T t)
        {
            d.Add(t);
            d.SaveChanges();
            return t;
        }

        public T Update(T t)
        {
            d.Update(t);
            d.SaveChanges();
            return t;
        }
    }
}
