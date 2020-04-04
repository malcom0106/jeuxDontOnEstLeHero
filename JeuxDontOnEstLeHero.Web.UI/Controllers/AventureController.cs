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
        private readonly DaoAventure _daoAventure = null;
        #endregion

        #region Constructeur avec injection de dépendance
        public AventureController(DaoAventure daoAventure)
        {
            this._daoAventure = daoAventure;
        }
        #endregion


        public IActionResult Index()
        {
            ViewBag.Titre = "Aventures";
            ViewBag.SousTitre = "Mes dernières aventures";
            List<Aventure> mesAventures = _daoAventure.GetAventures().Result;
            return View(mesAventures);
        }

        #region public methode Create

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aventure aventure)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_daoAventure.CreateAventure(aventure).Result)
                    {
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }

            }
            return View(aventure);
        }
        #endregion

        #region public methode Edit
        public IActionResult Edit(int id)
        {
            Aventure aventure = _daoAventure.GetAventureById(id).Result;
            return View(aventure);
        }
        [HttpPost]
        public IActionResult Edit(Aventure aventure)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_daoAventure.EditAventure(aventure).Result)
                    {
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return View(aventure);
        }
        #endregion
    }
}