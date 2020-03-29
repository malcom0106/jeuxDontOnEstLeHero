using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace jeudontonestlehero.Core.Data.DAO
{
    class DaoParagraphe
    {
        #region Variable Globale
        private readonly DefaultContext _context = null;
        #endregion

        #region Constructeur
        public DaoParagraphe(DefaultContext context)
        {
            this._context = context;
        }
        #endregion


    }
}
