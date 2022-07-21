using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class AppRoleModule
    {
        public int AppRoleModulesId { get; set; }
        public int AppRoleId { get; set;}
        public int ModuleId { get; set;}
        public int PermissionId { get; set; }
        public bool Active { get; set; }
    }
}
