using PokemonDbCreator_APIProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PokemonDbCreator_APIProject.Database.Maps
{
    public class PokemonMoveMap : EntityTypeConfiguration<PokemonMove>
    {
        public PokemonMoveMap()
        {
            ToTable(@"PokemonMove");

            HasKey(x => x.PokemonMove_id);

            Property(x => x.Pokemon_id);
            Property(x => x.Move_id);
        }
    }
}