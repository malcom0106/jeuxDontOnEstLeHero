using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Paragraphe
    {
        #region Proprietes
        /// <summary>
        /// Id venant de la BDD
        /// </summary>
        public int ParagrapheID { get; set; }

        /// <summary>
        /// Numero à afficher dans le jeu
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Titre du paragraphe
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        public string Description { set; get; }

        /// <summary>
        /// Question du paragraphe
        /// </summary>
        public Question maQuestion { get; set; }

        #endregion
    }
}
