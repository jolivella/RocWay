using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocWay.Domain.Entities;
using RocWay.Domain.Interface;
using RocWay.Infrastructure.Interface;

namespace RocWay.Domain.Core
{
    public class CustomerDomain : ICustomerDomain
    {
        public bool Delete(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Customer Get(string customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
