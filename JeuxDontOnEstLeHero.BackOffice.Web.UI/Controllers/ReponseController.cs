using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
{
    public class ReponseController : Controller
    {

        public IActionResult Add()
        {
            List<Question> questions = _context.Questions.ToList();
            ViewBag.MesQuestions = questions;
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