using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.DAO
{
    public class DaoAccess
    {
        #region Variable Globale
        protected readonly DefaultDBContext _context = null;
        #endregion

        #region Constructeur
        public DaoAccess(DefaultDBContext context)
        {
            this._context = context;
        }
        #endregion
    }
}
