using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
{
    public class QuestionController : BaseController
    {
        public QuestionController(DefaultContext context) : base(context)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            List<Paragraphe> paragraphes = _context.Paragraphes.ToList();
            ViewBag.MesParagraghes = paragraphes;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Question maquestion)
        {
            if (ModelState.IsValid)
            {
                _context.Questions.Add(maquestion);
                _context.SaveChanges();
            }
            List<Paragraphe> paragraphes = _context.Paragraphes.ToList();
            ViewBag.MesParagraghes = paragraphes;
            return View(maquestion);
        }
    }
}