using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class StoreHouse
    {
        [key]
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string WarehouseOwner { get; set; }// ten chu kho
        public List<Products> Products { get; set; } // lay du lieu tu kho
        public List<ImportHose> ImportHoses { get; set; }// lay du lieu cua nhap kho

    }
}
