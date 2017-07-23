using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonDbCreator_APIProject.Models;
using PokemonDbCreator_APIProject.Interfaces;
using PokemonDbCreator_APIProject.Database;

namespace PokemonDbCreator_APIProject.Repositories
{
    public class TypeRepository : Repository<Models.Type>, ITypeRepository
    {
    }
}