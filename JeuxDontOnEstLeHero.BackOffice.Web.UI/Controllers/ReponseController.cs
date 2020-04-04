using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.DAO;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
{
    public class ReponseController : Controller
    {
        private readonly DaoQuestion _daoQuestion = null;
        private readonly DaoReponse _daoReponse = null;
        private readonly List<Question> _questions = null;
        public ReponseController(DaoQuestion daoQuestion, DaoReponse daoReponse)
        {
            this._daoQuestion = daoQuestion;
            this._daoReponse = daoReponse;
            this._questions = daoQuestion.GetQuestions().Result;
        }

        public IActionResult Add()
        {            
            ViewBag.MesQuestions = _questions;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Reponse reponse)
        {
            if (ModelState.IsValid)
            {
                _context.Reponses.Add(reponse);
                _context.SaveChanges();
            }
            List<Question> questions = _context.Questions.ToList();
            ViewBag.MesQuestions = questions;
            return View(reponse);
        }
    }
}