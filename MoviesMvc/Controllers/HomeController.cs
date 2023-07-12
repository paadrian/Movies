using Microsoft.AspNetCore.Mvc;
using Movies.Web.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace Movies.Web.Controllers
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
            return View();
        }

        public string Hi(string name, int id = 0)
        {
            return HtmlEncoder.Default.Encode($"Name = {name}, id = {id}");
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = $"Hello {name}";
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public IActionResult Privacy()
        {
            var credentails = new NetworkCredential("123", "abc");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
