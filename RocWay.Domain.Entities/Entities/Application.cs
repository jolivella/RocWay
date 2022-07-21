using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Application
    {
        public int AppId { get; }
        public string App { get; set; }
        public string ApiSubscriptionKey { get; set; }
        public bool Active { get; set; }
    }
}
