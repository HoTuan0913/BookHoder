using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class Invoice_details
    {
        [key]
        public int Id { get; set; }
        public Invoices Invoices { get; set; }
        public string Address { get; set; }
        public int InvoicesId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Products products { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
