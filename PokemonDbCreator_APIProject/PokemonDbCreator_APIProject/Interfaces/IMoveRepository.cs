using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonDbCreator_APIProject.Models;
using PokemonDbCreator_APIProject.Interfaces;

namespace PokemonDbCreator_APIProject.Interfaces
{
    interface IMoveRepository : IRepository<Move>
    {
    }
}
