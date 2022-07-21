using RocWay.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocWay.Transversal.Common;

namespace RocWay.Application.Interface
{
    public interface ICustomerApplication
    {
        Response<bool> Insert(CustomerDto customersDto);
        Response<bool> Update(CustomerDto customersDto);
        Response<bool> Delete(int customerId);

        Response<CustomerDto> Get(int customerId);
        Response<IEnumerable<CustomerDto>> GetAll();
    }
}
