using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Reponse")]
    public class Reponse
    {
        #region Proprietes
        /// <summary>
        /// Id venant de la BDD
        /// </summary>
        [Key]
        public int ReponseId { get; set; }

        /// <summary>
        /// Proposition de réponse
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Foreign Key 
        /// </summary>
        public int QuestionID { get; set; }

        #endregion
    }
}
