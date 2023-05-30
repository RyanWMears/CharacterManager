using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class FeatController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public FeatController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetFeats()
        {
            List<Feat> output = _context.Feats.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddFeat(string values)
        {
            if (ModelState.IsValid) {
                Feat model = new Feat();
                JsonConvert.PopulateObject(values, model);
                _context.Feats.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditFeat(Guid key, string values)
        {
            var model = _context.Feats.Where(x => x.FeatId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteFeat(Guid key)
        {
            var model = _context.Feats.Where(x => x.FeatId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Feats.Remove(model);
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public JsonResult GetClassFeats()
        {
            List<ClassFeat> output = _context.ClassFeats.ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddClassFeat(string values)
        {
            if (ModelState.IsValid)
            {
                ClassFeat model = new ClassFeat();
                JsonConvert.PopulateObject(values, model);
                _context.ClassFeats.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditClassFeat(Guid key, string values)
        {
            var model = _context.ClassFeats.Where(x => x.ClassFeatId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteClassFeat(Guid key)
        {
            var model = _context.ClassFeats.Where(x => x.ClassFeatId == key).FirstOrDefault();
            if (model != null)
            {
                _context.ClassFeats.Remove(model);
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