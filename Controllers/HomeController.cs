using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CharacterManager.Controllers
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
        public IActionResult Class()
        {
            return View("Classes");
        }
        public IActionResult Feats()
        {
            return View("Feats");
        }
        public IActionResult Items()
        {
            return View("Items");
        }
        public IActionResult Languages()
        {
            return View("Languages");
        }
        public IActionResult Races()
        {
            return View("Races");
        }
        public IActionResult SavingThrows()
        {
            return View("SavingThrows");
        }
        public IActionResult Skills()
        {
            return View("Skills");
        }
        public IActionResult Spells()
        {
            return View("Spells");
        }
        
        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { ErrorId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}