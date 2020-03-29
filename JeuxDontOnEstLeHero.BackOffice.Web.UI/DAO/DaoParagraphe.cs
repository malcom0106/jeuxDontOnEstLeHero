using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.DAO
{
    public class DaoParagraphe : DaoAccess
    {
        public DaoParagraphe(DefaultContext context) : base(context)
        {
        }

        public bool ParagrapheExiste(object id)
        {
            bool existe = false;
            int paragrapheId = Convert.ToInt32(id);
            if(paragrapheId > 0)
            {
                var paragraphe = _context.Paragraphes.FirstOrDefault(p => p.ParagrapheId == paragrapheId);
                if(paragraphe != null)
                {
                    existe = true;
                }
            }
            return existe;
        }
    }
}
