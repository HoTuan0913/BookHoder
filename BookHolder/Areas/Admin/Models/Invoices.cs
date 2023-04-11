using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class Invoices
    {
        [key]
        public int Id { get; set; }         
        public List<Invoice_details> Invoice_Details { get; set; }  
        public List<ExportStore> ExportStores { get; set; }
        public int TransactStatusId { get; set; }
        public TransactStatus TransactStatus { get; set; }
        public int? CustomersId { get; set; }
        public Customers customers { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }        
    }
}
