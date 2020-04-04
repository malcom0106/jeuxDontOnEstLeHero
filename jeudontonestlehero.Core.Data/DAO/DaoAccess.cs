using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.DAO
{
    public class DaoAccess
    {
        #region Variable Globale
        protected readonly DefaultContext _context = null;
        #endregion

        #region Constructeur
        public DaoAccess(DefaultContext context)
        {
            this._context = context;
        }
        #endregion
    }
}
