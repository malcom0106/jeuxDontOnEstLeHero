using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecouverteValidator.Models;
using Microsoft.AspNetCore.Mvc;

namespace DecouverteValidator.Controllers
{
    public class JediController : Controller
    {


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Jedi jedi)
        {
            if (ModelState.IsValid)
            {
                //Vers la BDD
            }
            return View(jedi);
        }
    }
}