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
        private readonly DaoAventure _daoAventure = null;
        #endregion

        #region Constructeur
        public AventureController(DefaultContext context, DaoAventure daoAventure)
        {
            this._context = context;
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
                try {
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

        public async Task<List<Aventure>> GetAllAventures()
        {
            return await _context.Aventures.ToListAsync();
        }
    }
}