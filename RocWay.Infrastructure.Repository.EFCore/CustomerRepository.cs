using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocWay.Infrastructure.Interface;
using RocWay.Domain.Entities;
using RocWay.Infrastructure.Data.EFCore;

namespace RocWay.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly RocWayContext Context;
        public CustomerRepository(RocWayContext context) => Context = context;
        public bool Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
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

        public Task<Customer> Getasync(int id)
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
