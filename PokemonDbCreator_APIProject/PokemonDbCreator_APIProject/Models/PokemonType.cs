using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PokemonDbCreator_APIProject.Models
{
    public class PokemonType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PokemonType_id { get; set; }
        
        public int? Pokemon_id { get; set; }
        
        public Pokemon pokemon { get; set; }
        
        public int? Type_id { get; set; }

        public Type type { get; set; }
    }
}