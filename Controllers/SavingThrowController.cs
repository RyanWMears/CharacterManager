using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class SavingThrowController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public SavingThrowController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetSavingThrows()
        {
            List<SavingThrow> output = _context.SavingThrows.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddSavingThrow(string values)
        {
            if (ModelState.IsValid) {
                SavingThrow model = new SavingThrow();
                JsonConvert.PopulateObject(values, model);
                _context.SavingThrows.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditSavingThrow(Guid key, string values)
        {
            var model = _context.SavingThrows.Where(x => x.SavingThrowId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteSavingThrow(Guid key)
        {
            var model = _context.SavingThrows.Where(x => x.SavingThrowId == key).FirstOrDefault();
            if (model != null)
            {
                _context.SavingThrows.Remove(model);
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