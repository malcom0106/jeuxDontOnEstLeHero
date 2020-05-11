using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.DAO
{
    public class DaoReponse : DaoAccess
    {
        public DaoReponse(DefaultDBContext context) : base(context)
        {
        }

        /// <summary>
        /// Lister toutes les reponses
        /// </summary>
        /// <returns>Retourne une liste de Reponse</returns>
        public async Task<List<Reponse>> GetReponse()
        {
            List<Reponse> reponses = null;
            try
            {
                reponses = await _context.Reponses.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reponses;
        }


        /// <summary>
        /// Ajouter une reponse
        /// </summary>
        /// <param name="reponse">Une reponse</param>
        /// <returns>Retourne un boolean</returns>
        public async Task<bool> AddReponse(Reponse reponse)
        {
            bool IsValid = false;
            try
            {
                _context.Reponses.Add(reponse);
                await _context.SaveChangesAsync();
                IsValid = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsValid;
        }

    }
}
