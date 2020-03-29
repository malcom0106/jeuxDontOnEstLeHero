using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.DAO
{
    public abstract class DaoAccess
    {
        #region Variable Globale
        protected DefaultContext _context = null;
        #endregion

        #region Constructeur
        protected DaoAccess(DefaultContext context)
        {
            this._context = context;
        }
        #endregion
    }
}
