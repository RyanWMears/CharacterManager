using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public LanguageController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetLanguages()
        {
            List<Language> output = _context.Languages.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddLanguage(string values)
        {
            if (ModelState.IsValid) {
                Language model = new Language();
                JsonConvert.PopulateObject(values, model);
                _context.Languages.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditLanguage(Guid key, string values)
        {
            var model = _context.Languages.Where(x => x.LanguageId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteLanguage(Guid key)
        {
            var model = _context.Languages.Where(x => x.LanguageId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Languages.Remove(model);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public JsonResult GetClassLanguages()
        {
            List<ClassLanguage> output = _context.ClassLanguages.ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddClassLanguage(string values)
        {
            if (ModelState.IsValid)
            {
                ClassLanguage model = new ClassLanguage();
                JsonConvert.PopulateObject(values, model);
                _context.ClassLanguages.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditClassLanguage(Guid key, string values)
        {
            var model = _context.ClassLanguages.Where(x => x.ClassLanguageId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteClassLanguage(Guid key)
        {
            var model = _context.ClassLanguages.Where(x => x.ClassLanguageId == key).FirstOrDefault();
            if (model != null)
            {
                _context.ClassLanguages.Remove(model);
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