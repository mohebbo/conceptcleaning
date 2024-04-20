using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSite.Models;

namespace WebSite.Controllers
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
        public IActionResult aboutus()
        {
            return View();
        }
        public IActionResult commercialclean()
        {
            return View();
        }
        public IActionResult officeclean()
        {
            return View();
        }
        public IActionResult domesticcleaning()
        {
            return View();
        }
        public IActionResult professionalclean()
        {
            return View();
        }
        public IActionResult reliableclean()
        {
            return View();
        }
        public IActionResult tenancyclean()
        {
            return View();
        }
        public IActionResult ecofriendly()
        {
            return View();
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
