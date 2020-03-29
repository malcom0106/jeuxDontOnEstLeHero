using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        #region Proprietes

        /// <summary>
        /// Id venant de la BDD
        /// </summary>
        [Key]
        public int QuestionId { get; set; }

        /// <summary>
        /// Intitulé de la question
        /// </summary>
        [Required]
        public string Titre { get; set; }

        /// <summary>
        /// Id du paragraphe
        /// </summary>
        public int ParagrapheId { get; set; }

        /// <summary>
        /// Liste des reponse de cette question
        /// </summary>
        public List<Reponse> MesReponses { get; set; }

        #endregion

    }
}
