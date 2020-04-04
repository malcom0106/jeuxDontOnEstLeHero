using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.DAO;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
{
    public class QuestionController : Controller
    {
        private readonly DaoParagraphe _daoParagraphe = null;
        private readonly DaoQuestion _daoQuestion = null;
        private readonly List<Paragraphe> paragraphes = null;

        public QuestionController(DaoParagraphe daoParagraphe, DaoQuestion daoQuestion)
        {
            this._daoParagraphe = daoParagraphe;
            this._daoQuestion = daoQuestion;
            paragraphes = _daoParagraphe.GetAllParagraphes().Result;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            ViewBag.MesParagraghes = paragraphes;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Question maquestion)
        {
            if (ModelState.IsValid)
            {
                if (_daoQuestion.AddQuestion(maquestion).Result)
                {
                    return RedirectToAction("Index");
                }
            }

            ViewBag.MesParagraghes = paragraphes;
            return View(maquestion);
        }
    }
}