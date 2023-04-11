using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class ImportHose
    {
        [key]
        public int Id { get; set; }      
        public string ImportHoseName { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }// nha san xuat
        //danh sach kien ket
        public StoreHouse StoreHouse { get; set; }
        public List<ExportStore> ExportStores { get; set; }

    }
}
