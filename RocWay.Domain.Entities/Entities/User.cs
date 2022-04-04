using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public int ContractId { get; set; }
        public string CompleteName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public Contract Contract { get; set; }

        public ICollection<UserAppRole> AppRoles { get; set; }
    }
}
