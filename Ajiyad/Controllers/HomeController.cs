using System.Diagnostics;
using Ajiyad.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ajiyad.Controllers
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

        public IActionResult Projects() 
            // هاد هيك اسمه راوتنج 
        {
            return View();
        }
		public IActionResult SisterCompany()
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
