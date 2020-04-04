using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.DAO
{
    public class DaoAventure : DaoAccess
    {
        public DaoAventure(DefaultContext context) : base(context)
        {
        }

        public async Task<List<Aventure>> GetAventures()
        {
            try
            {
                List<Aventure> aventures = await _context.Aventures.ToListAsync();
                return aventures;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CreateAventure(Aventure aventure)
        {
            try
            {
                _context.Aventures.Add(aventure);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
