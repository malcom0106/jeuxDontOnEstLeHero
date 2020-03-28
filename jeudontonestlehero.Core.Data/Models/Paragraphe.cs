using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestlehero.Core.Data.Models
{
    //Evite de creer paragraphe avec un S en BDD
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Proprietes
        /// <summary>
        /// Id venant de la BDD
        /// </summary>
        [Key]
        public int ParagrapheID { get; set; }

        /// <summary>
        /// Numero à afficher dans le jeu
        /// </summary>
        [Required]  
        [Range(0,999999)]
        public int Numero { get; set; }

        /// <summary>
        /// Titre du paragraphe
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Titre { get; set; }

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Description { set; get; }

        /// <summary>
        /// Question du paragraphe
        /// </summary>
        public Question maQuestion { get; set; }

        #endregion
    }
}
