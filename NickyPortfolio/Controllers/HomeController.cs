using Microsoft.AspNetCore.Mvc;
using NickyPortfolio.Models;
using System.Diagnostics;

namespace NickyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string albumsDirectory = $"{Directory.GetCurrentDirectory()}\\Albums";
            string[] albumPaths = Directory.GetDirectories(albumsDirectory);
            string[] albumNames = albumPaths.Select(a => Path.GetFileName(a)).ToArray();

            return View(albumNames);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}