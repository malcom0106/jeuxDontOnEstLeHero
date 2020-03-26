using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Models
{
    /// <summary>
    /// Nom de la table dans SQLExpress
    /// </summary>
    [Table("Aventure")]
    public class Aventure
    {
        #region Proprietes
        public int AventureId { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string TypeAventure { get; set; }
        #endregion

        #region Constructeur
        public Aventure() { }
        public Aventure(string titre, string description, string typeAventure)
        {
            Titre = titre;
            Description = description;
            TypeAventure = typeAventure;
        }
        #endregion

    }
}
