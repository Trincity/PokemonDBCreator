using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using PokemonDbCreator_APIProject.Models;

namespace PokemonDbCreator_APIProject.Database.Maps
{
    public class PokemonMap : EntityTypeConfiguration<Pokemon>
    {
        public PokemonMap() {
            ToTable(@"Pokemon");

            HasKey(x => x.Pokemon_id);

            Property(x => x.name).IsRequired();
            Property(x => x.dexNo).IsRequired();
            Property(x => x.baseHP).IsRequired();
            Property(x => x.baseAttack).IsRequired();
            Property(x => x.baseDefense).IsRequired();
            Property(x => x.baseSpecialAttack).IsRequired();
            Property(x => x.baseSpecialDefense).IsRequired();
            Property(x => x.baseSpeed).IsRequired();
            Property(x => x.baseTotal).IsRequired();

            HasMany(x => x.pokemonMoves).WithOptional(x => x.pokemon).HasForeignKey(x => x.Pokemon_id);
            HasMany(x => x.types).WithOptional(x => x.pokemon).HasForeignKey(x => x.Pokemon_id);
        }
    }
}