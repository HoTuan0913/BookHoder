using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHolder.Controllers
{
    public class DetailproductController : Controller
    {
        public IActionResult Detailproduct()
        {
            return View();
        }
    }
}
