using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PokemonDbCreator_APIProject.Models;
using PokemonDbCreator_APIProject.Repositories;
using System.Web.Http.Cors;

namespace PokemonDbCreator_APIProject.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PokemonController : ApiController
    {
        static readonly IPokemonRepository repository = new PokemonRepository();

        // GET api/<controller>
        public IEnumerable<Pokemon> GetAllPokemon()
        {
            return repository.GetAll();
        }

        // GET api/<controller>/5
        public Pokemon Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Pokemon pokemon)
        {
            repository.Add(pokemon);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Pokemon pokemon)
        {
            repository.Update(id, pokemon);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return repository.Delete(id);
        }
    }
}