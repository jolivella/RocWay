using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Configuration
    {
        public int ConfigurationId { get; }
        public int ContractId { get; set; }
        public bool SingleBD { get; set; }
        public string StringConecction { get; set; }
    }
}
