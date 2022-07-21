using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocWay.Infrastructure.Interface;
using RocWay.Domain.Entities;
using RocWay.Infrastructure.Data.EFCore;
using Microsoft.EntityFrameworkCore;

namespace RocWay.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly RocWayContext Context;
        public CustomerRepository(RocWayContext context)
        {
            Context = context;
        }
        public bool Delete(int customerId)
        {
            try
            {
                var customer = Context.Customers.Find(customerId);
                Context.Entry(customer).State = EntityState.Deleted;
                Context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Customer Get(int id)
        {
            return Context.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
           return Context.Customers;
        }

        public bool Insert(Customer customer)
        {
            try
            {
                Context.Add(customer);
                Context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Customer customer)
        {
            try
            {
                Context.Entry(customer).State = EntityState.Modified;
                Context.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
    }
}
