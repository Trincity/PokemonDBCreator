using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonDbCreator_APIProject.Models
{
    [Table("Moves")]
    public class Move
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Move_id { get; set; }

        [Required]
        public int moveId { get; set; }

        [Required]
        public string name { get; set; }
        
        [Required]
        public string description { get; set; }

        [Required]
        public int type { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public string contest { get; set; }

        [Required]
        public int pp { get; set; }

        public int power { get; set; }
        
        public int accuracy { get; set; }

        [Required]
        public int gen { get; set; }
    }
}