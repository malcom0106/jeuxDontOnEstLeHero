using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.DAO
{
    public class DaoParagraphe
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

        public async Task<List<Paragraphe>> GetAllParagraphes()
        {
            return await _context.Paragraphes.ToListAsync();
        }

    }
}
