using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PokemonDbCreator_APIProject.Database.Maps
{
    public class TypeMap : EntityTypeConfiguration<Models.Type>
    {
        public TypeMap()
        {
            ToTable(@"Types");

            HasKey(x => x.Type_id);

            Property(x => x.type);
        }
    }
}