using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class ExportStore
    {
        [key]
        public int Id { get; set; }
        public ImportHose ImportHose { get; set; }
        public StoreHouse StoreHouse { get; set; }
        public List<Invoices> Invoices { get; set; }//danh sach hoa don
        public List<Products> Products { get; set; }//danh sach chi tiet san pham
    }
}
