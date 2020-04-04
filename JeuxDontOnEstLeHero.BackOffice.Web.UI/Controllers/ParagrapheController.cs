using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using jeudontonestlehero.Core.Data.DAO;
using Microsoft.AspNetCore.Mvc;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private readonly DaoParagraphe _doaParagraphe = null;

        public ParagrapheController(DaoParagraphe daoParagraphe)
        {
            this._doaParagraphe = daoParagraphe;
        }

        public IActionResult Index()
        {            

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Paragraphe paragraphe)
        {
            if (ModelState.IsValid)
            {
                this._context.Paragraphes.Add(paragraphe);
                this._context.SaveChanges();
            }
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
            if (ModelState.IsValid)
            {
                this._context.Update(paragraphe);
                this._context.SaveChanges();
            }
            return View(paragraphe);
        }

        #endregion

    }
}