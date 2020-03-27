using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region Variable Globale
        private readonly DefaultContext _context = null;
        #endregion

        #region Constructeur
        public ParagrapheController(DefaultContext context)
        {
            this._context = context;
        }
        #endregion
        
        #region Méthodes Publiques
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Paragraphe paragraphe)
        {
            this._context.Paragraphes.Add(paragraphe);
            this._context.SaveChanges();

            return View(paragraphe);
        }


        public IActionResult Edit(int id)
        {            
            return View(this._context.Paragraphes.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            this._context.Update(paragraphe);
            this._context.SaveChanges();
            return View(paragraphe);
        }

        #endregion

    }
}