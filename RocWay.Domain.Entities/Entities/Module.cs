using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Module
    {
        public int ModuleId { get; set; }
        public bool IsMenu { get; set; }
        public int Parent { get; set; }
        public string Url { get; set; }
        public int AppId { get; set; }
        public bool Active { get; set; }
    }
}
