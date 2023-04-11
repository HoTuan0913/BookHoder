using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class Products
    {
        [key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string image { get; set; }
        public int? ImageID { get; set; }
        public FileImage FileImage { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }       
        public string Describe { get; set; }
        public string release { get; set; }
        public string author { get; set; }
        public DateTime dateTime { get; set; }
        public string Category { get; set; }
        public int? productTypeId { get; set; }
        public ProductType productType { get; set; }
        public int View_Product { get; set; }
        public bool Status { get; set; }
        //danh sach lien ket
        public List<Invoice_details> Invoice_Details { get; set; }
        public ExportStore ExportStores { get; set; }
        public List<UserEvaluates> UserEvaluates { get; set; }
        public StoreHouse StoreHouse { get; set; }
    }
}