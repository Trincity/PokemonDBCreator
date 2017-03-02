using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonDbCreator_APIProject.Models;

namespace PokemonDbCreator_APIProject.Repositories
{
    interface IPokemonRepository
    {
        IEnumerable<Pokemon> GetAll();
        Pokemon Get(int id);
        Pokemon Add(Pokemon item);
        bool Update(int id, Pokemon item);
        bool Delete(int id);
    }
}
