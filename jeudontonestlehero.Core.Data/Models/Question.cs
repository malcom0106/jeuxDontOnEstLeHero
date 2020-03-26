using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Question
    {
        #region Proprietes
        /// <summary>
        /// Id venant de la BDD
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// Intitulé de la question
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Liste des reponse de cette question
        /// </summary>
        public List<Reponse> MesReponses { get; set; }
        #endregion

    }
}
