namespace PokemonDbCreator_APIProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PokemonDataContext : DbContext
    {
        public PokemonDataContext()
            : base("name=PokemonDataContext")
        {
        }

        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Move> Moves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Pokemon>()
                .Property(e => e.type1)
                .IsUnicode(false);

            modelBuilder.Entity<Pokemon>()
                .Property(e => e.type2)
                .IsUnicode(false);
        }
    }
}
