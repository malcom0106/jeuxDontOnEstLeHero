using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeuxDontOnEstLeHero.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using jeudontonestlehero.Core.Data;

namespace JeuxDontOnEstLeHero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titre = "Aventures";
            ViewBag.SousTitre = "Mes dernières aventures";
            List<Aventure> aventures = new List<Aventure>();
            aventures.Add(new Aventure("Ma 1er Aventure", "Ceci est une premeiere avnture", "Action"));
            aventures.Add(new Aventure("Ma 2nd Aventure", "Ceci est une seconde avnture", "Medieval"));
            return View(aventures);
        }
    }
}