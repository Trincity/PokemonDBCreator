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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int dexNo { get; set; }

        [Required]
        [StringLength(20)]
        public string type1 { get; set; }

        public string type2 { get; set; }
        
        [Required]
        public int baseHP { get; set; }

        [Required]
        public int baseAttack { get; set; }

        [Required]
        public int baseDefense { get; set; }

        [Required]
        public int baseSpecialAttack { get; set; }

        [Required]
        public int baseSpecialDefense { get; set; }

        [Required]
        public int baseSpeed { get; set; }

        [Required]
        public int baseTotal { get; set; }
    }
}
