using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeuxDontOnEstLeHero.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using jeudontonestlehero.Core.Data.DAO;

namespace JeuxDontOnEstLeHero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        #region Variable Globale
        private readonly DefaultContext _context = null;
        private readonly DaoParagraphe _daoParagraphe = null;
        #endregion

        #region Constructeur
        public AventureController(DefaultContext context, DaoParagraphe daoParagraphe)
        {
            this._context = context;
            this._daoParagraphe = daoParagraphe;
        }
        #endregion

        public IActionResult Index()
        {            
            ViewBag.Titre = "Aventures";
            ViewBag.SousTitre = "Mes dernières aventures";
            List<Aventure> mesAventures = GetAllAventures().Result;
            return View(mesAventures);
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

        public async Task<List<Aventure>> GetAllAventures()
        {
            return await _context.Aventures.ToListAsync();
        }
    }
}