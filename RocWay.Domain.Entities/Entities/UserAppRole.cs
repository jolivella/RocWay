using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class UserAppRole
    {
        public int UserAppRoleId { get; set; }
        public int AppRoleId { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }

        public AppRole AppRole { get; set; }
        public User User { get; set; }
    }
}
