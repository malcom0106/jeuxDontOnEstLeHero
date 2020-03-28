using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DecouverteValidator.Models
{
    public class Jedi
    {
        [Required]
        public string Nom { get; set; }

        [Range(1, 300)]
        public int Size { get; set; }

    }
}
