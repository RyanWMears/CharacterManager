using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class RaceController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public RaceController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetRaces()
        {
            List<Race> output = _context.Races.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddRace(string values)
        {
            if (ModelState.IsValid) {
                Race model = new Race();
                JsonConvert.PopulateObject(values, model);
                _context.Races.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditRace(Guid key, string values)
        {
            var model = _context.Races.Where(x => x.RaceId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteRace(Guid key)
        {
            var model = _context.Races.Where(x => x.RaceId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Races.Remove(model);
                _context.SaveChanges();
            }
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