using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CharacterController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Player model = new Player();
            //model = testPlayer(model);
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

        public ActionResult loadPlayerData()
        {
            Player model = new Player();
            model = new Player(
                "Saren",
                1,
                new AbilityScores(
                    10, 15, 12, 10, 8, 16
                    ),
                new Proficiency(
                    new SavingThrows(
                        true, true, true, false, false, false
                        ),
                    new Skills(
                        true, true, true, false, false, false, true, true, true, false, false, false, true, true, true, false, false, false
                        )
                    )
                );
            return Json(model);
        }
    }
}