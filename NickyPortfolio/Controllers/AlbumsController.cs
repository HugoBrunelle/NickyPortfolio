using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        [HttpGet]
        public IActionResult Index(string id)
        {
            return View(model: id);
        }

        [HttpGet]
        public JsonResult GetAlbum(string name)
        {
            // Verify if the album exist first
            // Then perform the task
            string albumPath = $".\\Albums\\{name}";
            string[] imagesPath = Directory.GetFiles(albumPath);

            if (imagesPath.Length == 0)
                return new JsonResult(Ok());

            string[] imagesBase64 = imagesPath
                .Select(i => Convert.ToBase64String(System.IO.File.ReadAllBytes(i)))
                .ToArray();

            return new JsonResult(Ok(imagesBase64));
        }
    }
}
