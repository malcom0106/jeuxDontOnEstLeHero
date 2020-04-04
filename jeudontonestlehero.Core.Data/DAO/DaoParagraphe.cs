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

        public async Task<bool> CreateParagraphe(Paragraphe paragraphe)
        {
            bool IsValid = false;

            try
            {
                this._context.Paragraphes.Add(paragraphe);
                await this._context.SaveChangesAsync();
                IsValid = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return IsValid;
        }

        public async Task<bool> EditParagraphe(Paragraphe paragraphe)
        {
            bool IsValid = false;

            try
            {
                this._context.Update(paragraphe);
                await this._context.SaveChangesAsync();
                IsValid = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsValid;
        }

        public async Task<Paragraphe> GetParagrapheById(int id)
        {
            try
            {
                return await this._context.Paragraphes.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
