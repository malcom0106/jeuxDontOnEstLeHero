using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    public class DefaultContext : DbContext
    {
        #region Constructeur
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }
        #endregion

        #region Propriete
        public DbSet<Aventure> Aventures { get; set; }
         public DbSet<Paragraphe> Paragraphes { get; set; }
         public DbSet<Question> Questions { get; set; }
         public DbSet<Reponse> Reponses { get; set; }

        #endregion
    }
}
