using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class FileImage
    {
        [key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string image { get; set; }
        public List<Products> Customers { get; set; }
    }
}
