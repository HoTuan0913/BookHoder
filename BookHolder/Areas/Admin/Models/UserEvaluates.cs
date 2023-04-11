using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Areas.Admin.Models
{
    public class UserEvaluates
    {
        [key]
        public int Id { get; set; }
        public Customers Customers { get; set; }
        public Products Products { get; set; }
        public int StarQuantity { get; set; }
        public DateTime CommentTime { get; set; }
        public string CodeEvaluates { get; set; }

    }
}
