using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PokemonDbCreator_APIProject.Models
{
    public class PokemonMove
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PokemonMove_id { get; set; }
        
        public int? Pokemon_id { get; set; }
        
        public virtual Pokemon pokemon { get; set; }
        
        public int? Move_id { get; set; }
        
        public virtual Move move { get; set; }
    }
}