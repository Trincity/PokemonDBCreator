namespace PokemonDbCreator_APIProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pokemon")]
    public partial class Pokemon
    {
        public Pokemon()
        {
            pokemonMoves = new List<PokemonMove>();
            types = new List<PokemonType>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pokemon_id { get; set; }
        
        [StringLength(50)]
        public string name { get; set; }

        public int dexNo { get; set; }
        
        public int baseHP { get; set; }
        
        public int baseAttack { get; set; }
        
        public int baseDefense { get; set; }
        
        public int baseSpecialAttack { get; set; }
        
        public int baseSpecialDefense { get; set; }
        
        public int baseSpeed { get; set; }
        
        public int baseTotal { get; set; }
        
        public virtual ICollection<PokemonType> types { get; set; }
        
        public virtual ICollection<PokemonMove> pokemonMoves { get; set; }
    }
}
