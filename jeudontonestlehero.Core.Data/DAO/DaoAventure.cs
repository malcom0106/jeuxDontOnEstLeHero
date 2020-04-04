using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.DAO
{
    class DaoAventure : DaoAccess
    {
        public DaoAventure(DefaultContext context) : base(context)
        {
        }

        public async Task<List<Aventure>> GetAventures()
        {
            List<Aventure> aventures = await _context.Aventures.ToListAsync();
            return aventures;
        }
    }
}
