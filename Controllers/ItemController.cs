using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterManager.Controllers
{
    public class ItemController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDBContext _context = new ApplicationDBContext();

        public ItemController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetItems()
        {
            List<Item> output = _context.Items.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpGet]
        public JsonResult GetArmor()
        {
            List<Item> output = _context.Items.Where(x => x.Type == "Armor").OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpGet]
        public JsonResult GetWeapons()
        {
            List<Item> output = _context.Items.Where(x => x.Type == "Weapon").OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpGet]
        public JsonResult GetTools()
        {
            List<Item> output = _context.Items.Where(x => x.Type == "Tool").OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddItem(string values)
        {
            if (ModelState.IsValid) {
                Item model = new Item();
                JsonConvert.PopulateObject(values, model);
                _context.Items.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditItem(Guid key, string values)
        {
            var model = _context.Items.Where(x => x.ItemId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteItem(Guid key)
        {
            var model = _context.Items.Where(x => x.ItemId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Items.Remove(model);
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