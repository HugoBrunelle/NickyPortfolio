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
            Dictionary<string, string> thumbnail = new();
            string[] albumPaths = Directory.GetDirectories(".\\Albums");
            string[] albumNames = albumPaths.Select(a => Path.GetFileName(a)).ToArray();

            foreach(string name in albumNames)
            {
                string[] images = Directory.GetFiles($".\\Albums\\{name}");
                if (images.Length > 0)
                {
                    thumbnail.Add(name, Convert.ToBase64String(System.IO.File.ReadAllBytes(images.First())));
                }
                else
                {
                    thumbnail.Add(name, String.Empty);
                }
            }
            return View(thumbnail);
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