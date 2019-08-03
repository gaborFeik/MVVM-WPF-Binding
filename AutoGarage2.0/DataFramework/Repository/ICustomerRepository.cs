using AutoGarage2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.DataFramework.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerModel> GetAll();
        CustomerModel GetById(int CustomerID);
        void Add(CustomerModel customer);
        void Remove(CustomerModel customer);
        void Find(int CustomerID);
    }
}
