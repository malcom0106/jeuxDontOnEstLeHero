using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    public class DefaultDBContext : DbContext
    {
        #region Constructeur
        public DefaultDBContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultDBContext()
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
