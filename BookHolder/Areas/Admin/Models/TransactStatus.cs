using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class TransactStatus
    {
        [key]
        public int TransactStatusId { get; set; }
        public List<Invoices> Invoices { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
