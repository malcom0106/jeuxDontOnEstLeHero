using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.DAO
{
    public class DaoParagraphe : DaoAccess
    {
        public DaoParagraphe(DefaultContext context) : base(context)
        {
        }

        public async Task<List<Paragraphe>> GetAllParagraphes()
        {
            return await _context.Paragraphes.ToListAsync();
        }

    }
}
