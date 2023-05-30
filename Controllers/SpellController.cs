﻿using CharacterManager.DAL;
using CharacterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
            List<Spell> output = _context.Spells.OrderBy(x => x.Name).ToList();

            return Json(output);
        }

        [HttpPost]
        public void AddSpell(string values)
        {
            if (ModelState.IsValid) {
                Spell model = new Spell();
                JsonConvert.PopulateObject(values, model);
                _context.Spells.Add(model);

                _context.SaveChanges();
            }
        }

        [HttpPost]
        public void EditSpell(Guid key, string values)
        {
            var model = _context.Spells.Where(x => x.SpellId == key).FirstOrDefault();
            if (model != null)
            {
                JsonConvert.PopulateObject(values, model);
            }

            _context.SaveChanges();
        }

        [HttpPost]
        public void DeleteSpell(Guid key)
        {
            var model = _context.Spells.Where(x => x.SpellId == key).FirstOrDefault();
            if (model != null)
            {
                _context.Spells.Remove(model);
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