using BL.Abstract;
using DAL.Abstract;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomer _dal;
        public CustomerManager(ICustomer dal)
        {
            _dal = dal;
        }
        public Customer CustomerAdd(Customer customer)
        {
            if (customer != null)
            {
                customer.CompanyGroupId = 1;
                customer.Number = "1";
                customer.TypeId = 2;
                customer.IsActive = true;
                if (string.IsNullOrEmpty(customer.Title))
                    customer.Title = customer.Name + " " + customer.Surname;
                return _dal.Insert(customer);
            }
            else
            {
                return null;
            }
        }

        public List<Customer> GetList()
        {
            return _dal.GetListAll().ToList();
        }
    }
}
