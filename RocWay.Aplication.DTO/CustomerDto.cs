using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RocWay.Application.DTO
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string Nit { get; set; }
        public string RegimenType { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
    }
}
