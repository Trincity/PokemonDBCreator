using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PokemonDbCreator_APIProject.Models;
using System.Web.Http.Cors;
using PokemonDbCreator_APIProject.Database;

namespace PokemonDbCreator_APIProject.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PokemonController : ApiController
    {
        static readonly PokemonDatabase db = new PokemonDatabase();

        // GET api/<controller>
        public IQueryable<Pokemon> GetAllPokemon()
        {
            return db.Pokemons;
        }

        // GET api/<controller>/5
        [ResponseType(typeof(Models.Pokemon))]
        public IHttpActionResult Get(int id)
        {
            Pokemon pokemon = db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return Ok(pokemon);
        }

        // POST api/<controller>
        [ResponseType(typeof(Pokemon))]
        public IHttpActionResult Post([FromBody]Pokemon pokemon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pokemons.Add(pokemon);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pokemon.Pokemon_id }, pokemon);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]Pokemon pokemon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pokemon.Pokemon_id)
            {
                return BadRequest();
            }

            db.Entry(pokemon).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PokemonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/<controller>/5
        [ResponseType(typeof(Pokemon))]
        public IHttpActionResult Delete(int id)
        {
            Pokemon pokemon = db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return NotFound();
            }

            db.Pokemons.Remove(pokemon);
            db.SaveChanges();

            return Ok(pokemon);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PokemonExists(int id)
        {
            return db.Pokemons.Count(e => e.Pokemon_id == id) > 0;
        }
    }
}