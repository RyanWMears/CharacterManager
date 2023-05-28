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
            //Character model = new Character();
            //model = testCharacter(model);
            return View();
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

        public ActionResult loadCharacterData()
        {
            Character model = new Character();
            //model = new Character(
            //    "Saren",
            //    1,
            //    new AbilityScores(
            //        10, 15, 12, 10, 8, 16
            //        ),
            //    new Proficiency(
            //        new SavingThrows(
            //            true, true, true, false, false, false
            //            ),
            //        new Skills(
            //            true, true, true, false, false, false, true, true, true, false, false, false, true, true, true, false, false, false
            //            )
            //        )
            //    );
            return Json(model);
        }
    }
}