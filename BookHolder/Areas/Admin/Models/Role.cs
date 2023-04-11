using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class Role
    {
        [key]
        public int RoleId { get; set; }
        public List<Customers> customers { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
