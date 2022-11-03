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
        public async Task<IActionResult> Index()
        {
              return View();
        }

        // GET: Albums/ShowSearchPage
        public async Task<IActionResult> ShowSearchPage()
        {
            return View();
        }

        // GET: Albums/ShowSearchResult
        public async Task<IActionResult> ShowSearchResult(String SearchPhrase)
        {
            return View("Index");
        }

        // GET: Albums/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
