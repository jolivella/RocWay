using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocWay.Domain.Entities;

namespace RocWay.Domain.Interface
{
    public interface ICustomerDomain
    {

        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int customerId);

        Customer Get(int customerId);
        IEnumerable<Customer> GetAll();
    }
}
