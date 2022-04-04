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
        bool Delete(Customer customer);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();

        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(Customer customer);
        Task<Customer> Getasync(int id);
        Task<IEnumerable<Customer>> GetAllAsync();
    }
}
