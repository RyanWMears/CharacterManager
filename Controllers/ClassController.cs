using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class ClassController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public ClassController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetClasses()
        {
            List<Class> output = _context.Classes.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddClass(string values)
        {
            if (ModelState.IsValid) {
                Class model = new Class();
                JsonConvert.PopulateObject(values, model);
                _context.Classes.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditClass(Guid key, string values)
        {
            var model = _context.Classes.Where(x => x.ClassId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteClass(Guid key)
        {
            var model = _context.Classes.Where(x => x.ClassId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Classes.Remove(model);
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