using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class SkillController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public SkillController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetSkills()
        {
            List<Skill> output = _context.Skills.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddSkill(string values)
        {
            if (ModelState.IsValid) {
                Skill model = new Skill();
                JsonConvert.PopulateObject(values, model);
                _context.Skills.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditSkill(Guid key, string values)
        {
            var model = _context.Skills.Where(x => x.SkillId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteSkill(Guid key)
        {
            var model = _context.Skills.Where(x => x.SkillId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Skills.Remove(model);
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