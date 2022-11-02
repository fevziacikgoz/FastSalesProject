using BL.Abstract;
using DAL.Abstract;
using DAL.Entity;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategory _dal;
        public CategoryManager(ICategory dal)
        {
            _dal = dal;
        }
        public List<Category> GetList()
        {
            return _dal.GetListAll().Where(w => w.IsFastSelling).Take(10).ToList();
        }
    }
}
