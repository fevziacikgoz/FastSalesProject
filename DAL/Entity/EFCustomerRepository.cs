using DAL.Abstract;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{

    public class EFCustomerRepository : GenericRepository<Customer>, ICustomer
    {
    }
}
