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
    public class PokemonTypeMap : EntityTypeConfiguration<PokemonType>
    {
        public PokemonTypeMap()
        {
            ToTable(@"PokemonType");

            HasKey(x => x.PokemonType_id);

            Property(x => x.Pokemon_id);
            Property(x => x.Type_id);
        }
    }
}