using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class SaleOff
    {
        [key]
        public int Id { get; set; }
        public int intSale { get; set; }
        public DateTime dateTimeStrart { get; set; }
        public DateTime dateTimeEnd { get; set; }
        /*public List<Invoices> saleOffs { get; set; }*/
    }
}
