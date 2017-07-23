using PokemonDbCreator_APIProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PokemonDbCreator_APIProject.Database.Maps
{
    public class MoveMap : EntityTypeConfiguration<Move>
    {
        public MoveMap()
        {
            ToTable(@"Moves");

            HasKey(x => x.Move_id);

            Property(x => x.moveId);
            Property(x => x.name);
            Property(x => x.type);
            Property(x => x.gen);
            Property(x => x.description);
            Property(x => x.power);
            Property(x => x.accuracy);
            Property(x => x.contest);
            Property(x => x.category);

        }
    }
}