using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public bool Active { get; set; }

        public ICollection<AppRoleModule> AppRoleModules { get; set; }
    }
}
