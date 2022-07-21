using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocWay.Domain.Entities;

namespace RocWay.Infrastructure.Interface
{
    public interface ICustomerRepository
    {
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
    }
}
