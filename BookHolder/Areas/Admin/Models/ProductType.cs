using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class ProductType
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Products> Products { get; set; }
    }
}
