using PokemonDbCreator_APIProject.Interfaces;
using PokemonDbCreator_APIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonDbCreator_APIProject.Repositories
{
    public class PokemonMoveRepository : Repository<PokemonMove>, IPokemonMoveRepository
    {
    }
}