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
        private readonly DaoParagraphe _daoParagraphe = null;
        private readonly List<Paragraphe> paragraphes = null;

        public ParagrapheController(DaoParagraphe daoParagraphe)
        {
            this._daoParagraphe = daoParagraphe;
            paragraphes = _daoParagraphe.GetAllParagraphes().Result;
        }

        public IActionResult Index()
        {
            return View(paragraphes);
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
                if (_daoParagraphe.CreateParagraphe(paragraphe).Result)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(paragraphe);
        }


        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = _daoParagraphe.GetParagrapheById(id).Result;
            return View(paragraphe);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            if (ModelState.IsValid)
            {
                if (_daoParagraphe.EditParagraphe(paragraphe).Result)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(paragraphe);
        }

    }
}