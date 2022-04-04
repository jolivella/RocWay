using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Customer
    {
        public int TenantId { get; set; } 
        public string Nit { get; set; }
        public string RegimenType { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
