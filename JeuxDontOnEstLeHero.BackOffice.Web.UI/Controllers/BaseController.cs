using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
{
    public class BaseController : Controller
    {
        #region Variable Globale
        public readonly DefaultContext _context = null;
        #endregion

        #region Constructeur
        public BaseController(DefaultContext context)
        {
            this._context = context;
        }
        #endregion
    }
}