using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Reponse
    {
        #region Proprietes
        /// <summary>
        /// Id venant de la BDD
        /// </summary>
        public int ReponseId { get; set; }

        /// <summary>
        /// Proposition de réponse
        /// </summary>
        public string Description { get; set; }


        #endregion
    }
}
