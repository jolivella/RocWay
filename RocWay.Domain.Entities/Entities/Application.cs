using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Application:AuditFields
    {
        public int AppId { get; set; }
        public string App { get; set; }
        public string ApiSubscriptionKey { get; set; }
        public bool Active { get; set; }

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<AppRole> AppRoles { get; set; }
    }
}
