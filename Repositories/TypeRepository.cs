using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonDbCreator_APIProject.Models;

namespace PokemonDbCreator_APIProject.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        PokemonDataContext PokemonDB = new PokemonDataContext();

        public IEnumerable<Models.Type> GetAll()
        {
            return PokemonDB.Types;
        }

        public Models.Type Get(int id)
        {
            return PokemonDB.Types.Find(id);
        }

        public Models.Type Add(Models.Type type)
        {
            if(type == null)
            {
                throw new ArgumentNullException("type");
            }

            PokemonDB.Types.Add(type);
            PokemonDB.SaveChangesAsync();
            return type;
        }

        public bool Update(int id, Models.Type type)
        {
            if(type == null)
            {
                throw new ArgumentNullException("type");
            }

            var types = PokemonDB.Types.Single(a => a.id == type.id);
            types.type = type.type;
            PokemonDB.SaveChangesAsync();
            return true;
        }

        public bool Delete(int id)
        {
            Models.Type type = PokemonDB.Types.Find(id);
            PokemonDB.Types.Remove(type);
            PokemonDB.SaveChangesAsync();
            return true;
        }
    }
}