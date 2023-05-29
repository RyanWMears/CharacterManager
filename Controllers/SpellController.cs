using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class SpellController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public SpellController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetSpells()
        {
            List<Spell> output = _context.Spells.ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddSpell(Spell spell)
        {
            _context.Spells.Add(spell);

            _context.SaveChanges();
        }


        public void DeleteSpell(Guid key)
        {
            var model = _context.Spells.Where(x => x.SpellId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Spells.Remove(model);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public JsonResult GetSpells2 (int skip, int take)
        {
            List<Spell> output = _context.Spells.Skip(skip).Take(take).ToList();


            return Json(output);
        }

        //[HttpGet]
        //public HttpResponseMessage GetSpells2(DataSourceLoader loadOptions)
        //{

        //    return Request.CreateResponse(DataSourceLoader.Load(_context.Spells, loadOptions));
        //}

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