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
        private readonly ICustomerRepository customerRepository;

        public CustomerDomain(ICustomerRepository CustomerRepository)
        {
            customerRepository = CustomerRepository;
        }

        public bool Delete(int customerId)
        {
            return customerRepository.Delete(customerId);
        }

        public Customer Get(int customerId)
        {
            return customerRepository.Get(customerId);

        }

        public IEnumerable<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public bool Insert(Customer customer)
        {
            return customerRepository.Insert(customer);
        }

        public bool Update(Customer customer)
        {
            return customerRepository.Update(customer);

        }
    }
}
