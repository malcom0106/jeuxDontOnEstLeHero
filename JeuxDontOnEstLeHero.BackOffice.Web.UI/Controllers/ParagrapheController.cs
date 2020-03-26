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
        #region A supprimer avec entities
        private List<Paragraphe> paragraphes = new List<Paragraphe>() {
            new Paragraphe()
            {
                ParagrapheID=1,
                Numero=1,
                Description="Description1",
                Titre = "Titre 1"
            },
            new Paragraphe()
            {
                ParagrapheID=2,
                Numero=2,
                Description="Description2",
                Titre = "Titre 2"
            },
            new Paragraphe()
            {
                ParagrapheID=3,
                Numero=3,
                Description="Description3",
                Titre = "Titre 3"
            },
        };
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
            return View(paragraphe);
        }


        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = paragraphes.Where(p => p.ParagrapheID == id).FirstOrDefault();
            return View(paragraphe);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            return View(paragraphe);
        }
        #endregion

    }
}