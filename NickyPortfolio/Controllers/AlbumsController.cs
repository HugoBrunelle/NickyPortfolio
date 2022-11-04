using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NickyPortfolio.Models;

namespace NickyPortfolio.Controllers
{
    public class AlbumsController : Controller
    {

        public AlbumsController()
        {
        }

        // GET: Albums
        public IActionResult Index()
        {
              return View();
        }
    }
}
