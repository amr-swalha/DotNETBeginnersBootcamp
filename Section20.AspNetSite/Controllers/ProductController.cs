using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Section20.AspNetSite.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}