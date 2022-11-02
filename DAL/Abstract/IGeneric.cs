using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGeneric<T> where T : class
    {
        T Insert(T t);
        T Update(T t);
        T Delete(T t);
        IQueryable<T> GetListAll(string[] including = null);
        T GetBy(int id);
    }
}
