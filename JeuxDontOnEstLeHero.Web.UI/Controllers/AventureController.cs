using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeuxDontOnEstLeHero.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;

namespace JeuxDontOnEstLeHero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        #region Variable Globale
        private readonly DefaultContext _context = null;
        #endregion

        #region Constructeur
        public AventureController(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        public IActionResult Index([FromServices] DefaultContext context)
        {
            ViewBag.Titre = "Aventures";
            ViewBag.SousTitre = "Mes dernières aventures";

            var query = from aventures in context.Aventures
                        select aventures;
            
            return View(query.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aventure aventure)
        {
            if (ModelState.IsValid)
            {                
                _context.Aventures.Add(aventure);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aventure);
        }


        public IActionResult Edit(int id)
        {
            return View(_context.Aventures.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Aventure aventure)
        {
            if (ModelState.IsValid)
            {
                _context.Aventures.Update(aventure);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aventure);
        }
    }
}