using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Openskill.Helpers.Enums;
using Openskill.Helpers.Filters;
using Openskill.Models;
using System.Diagnostics;

namespace Openskill.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Menu(MenuItem.AboutUs)]
        public IActionResult Index()
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