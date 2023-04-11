using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class Customers
    {
        [key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Invoices> Invoices { get; set; }
        public List<UserEvaluates> UserEvaluates { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime Brithday { get; set; }
       /* public string ClassifyCustomers { get; set; }*/
        public bool Status { get; set; }

        /*internal object FirstOrDefault()
        {
            throw new NotImplementedException();
        }*/
    }
}
