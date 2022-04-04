using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ContractId { get; set; }
        public double Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaidPeriod { get; set; }

        public Contract Contract { get; set; }
    }
}
