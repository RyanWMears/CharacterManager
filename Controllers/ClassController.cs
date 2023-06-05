using CharacterManager.DAL;
using CharacterManager.Models;
using CharacterManager.Models.JoinModels.ClassJoins;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Linq;
using System.Web.Helpers;

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
            foreach (Class cl in output)
            {                
                cl.SkillIds =  _context.ClassSkills.Where(x => x.ClassId == cl.ClassId).Select(x => x.SkillId).ToList();
                cl.SavingThrowIds =  _context.ClassSavingThrows.Where(x => x.ClassId == cl.ClassId).Select(x => x.SavingThrowId).ToList();
            }
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

                foreach (Guid skillId in model.SkillIds)
                {
                    ClassSkill classSkill = new ClassSkill(model.ClassId, skillId);
                    _context.ClassSkills.Add(classSkill);
                }

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
                _context.SaveChanges();

                foreach (Guid skillId in model.SkillIds)
                {
                    ClassSkill classSkill = new ClassSkill(model.ClassId, skillId);
                    _context.ClassSkills.Add(classSkill);
                }

                foreach (Guid savingThrowId in model.SavingThrowIds)
                {
                    ClassSavingThrow classSavingThrow = new ClassSavingThrow(model.ClassId, savingThrowId);
                    _context.ClassSavingThrows.Add(classSavingThrow);
                }
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
        public IActionResult _ViewClass(Guid key)
        {
            if (key != Guid.Empty)
            {
                var model = _context.Classes.Where(x => x.ClassId == key).FirstOrDefault();
                if (ModelState.IsValid)
                {
                    return PartialView("_ViewClass", model);
                }
            }
            return PartialView("_ViewClass", null);
        }

        public IActionResult _EditClass(Guid key)
        {
            Class model = new Class();
            if (key != Guid.Empty && key != null)
            {
                model = _context.Classes.Where(x => x.ClassId == key).FirstOrDefault();
                if (ModelState.IsValid)
                {
                    return PartialView("_EditClass", model);
                }
            }
            return PartialView("_EditClass", null);
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