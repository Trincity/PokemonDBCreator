using PokemonDbCreator_APIProject.Database.Maps;
using PokemonDbCreator_APIProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PokemonDbCreator_APIProject.Database
{
    public class PokemonDatabase : DbContext
    {
        public PokemonDatabase()
            : base("name=PokemonDataContext")
        {
        }

        public virtual IDbSet<Pokemon> Pokemons { get; set; }
        public virtual IDbSet<Models.Type> Types { get; set; }
        public virtual IDbSet<Move> Moves { get; set; }
        public virtual IDbSet<PokemonMove> PokemonMoves { get; set; }
        public virtual IDbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PokemonMap());
            modelBuilder.Configurations.Add(new MoveMap());
            modelBuilder.Configurations.Add(new TypeMap());
            modelBuilder.Configurations.Add(new PokemonMoveMap());
            modelBuilder.Configurations.Add(new PokemonTypeMap());
        }
    }
}