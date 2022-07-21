using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Contract
    {
        public int ContractId { get; set; }
        public int CustomerId { get; set; }
        public int AppId { get; set; }
        public string ContractType { get; set; }
        public string ContractValidity { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int MaximunUsers { get; set; }
        public double Cost { get; set; }
        public int PaymentFrecuency { get; set; }
        public bool Active { get; set; }
    }
}
