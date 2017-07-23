using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using PokemonDbCreator_APIProject.Database;
using System.Threading.Tasks;

namespace PokemonDbCreator_APIProject.Models
{
    public partial class PokemonDataContext
    {
        private PokemonDatabase _database;

        public PokemonDataContext(PokemonDatabase database)
        {
            _database = database;
        }

        public Task<int> SaveChangesAsync()
        {
            try
            {
                return _database.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public DbContextTransaction BeginTransaction()
        {
            return _database.Database.BeginTransaction();
        }
    }
}
