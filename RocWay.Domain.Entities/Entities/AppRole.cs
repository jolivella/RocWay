using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class AppRole
    {
        public int AppRoleId { get; set; }
        public int RoleId { get; set; }
        public int AppId { get; set; }
        public bool Active { get; set; }
    }
}
